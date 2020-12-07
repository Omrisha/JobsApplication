import React, { Component } from 'react';
import Button from "reactstrap/es/Button";
import { Container, ListGroup, Row, Col } from 'react-bootstrap';
import { Autocomplete } from '@material-ui/lab';
import { TextField } from '@material-ui/core';
import { AsyncTypeahead } from 'react-bootstrap-typeahead';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { jobs: [], options: [], loading: false, value: '' };

    
  }

  handleClick() {
    const value = this.state.value;
    console.log(value);
    fetch('/api/Jobs/' + value).then(result => {
      console.log(result);
      if (result.status === 200) {
        result.json().then(json => {
          console.log(json);
          this.setState({ jobs: json });
        });
      }
    });
  }

  async onAccountSearch(query) {
    if (query.length < 2) {
      return;
    }

    this.setState({ loading: true });
    fetch('/api/Jobs/Titles/' + query)
     .then((results) => {
      if (results) {
        results.json().then((content) => {
          console.log(content);
          this.setState({ options: content, loading: false });
        });
      }
     });
  }

  render() {
    let { jobs, options, value, loading } = this.state;

    return (
        <div  style={{display: 'flex', justifyContent: 'center'}}>
          <Container>
            <Row>
              <Col>
                <AsyncTypeahead
                  id={"jobs_identifier"}
                  delay={500}
                  placeholder={"Search for jobs"}
                  isLoading={loading}
                  onSearch={(query) => this.onAccountSearch(query)}
                  options={options}
                  multiple={true}
                  onChange={(newValue) => this.setState({value: newValue})}
                  />
                <Button variant="primary" onClick={() => this.handleClick()} style={{margin: 12}}>Search</Button>
              </Col>
            </Row>
            <Row>
            <Col>
              <ListGroup>
                {jobs.map(element => (
                  <ListGroup.Item key={element}>{element}</ListGroup.Item>
                ))}
              </ListGroup>
            </Col>
          </Row>
          </Container>
        </div>
    );
  }
}