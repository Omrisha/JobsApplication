using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime;

namespace JobsApplication
{
    [Table("Test_Jobs")]
    public class JobEntity
    {
        [Column("JobId")]
        public int Id { get; set; }
        [Column("JobTitleId")]
        public int TitleId { get; set; }
        [Column("CategoryId")]
        public int CategoryId { get; set; }
        [Column("City")]
        public string City { get; set; }
        [Column("State")]
        public string State { get; set; }
        [Column("DescriptionLength")]
        public int? DescriptionLength { get; set; }
        [Column("EducationLevel")]
        public int? EducationLevel { get; set; }
        [Column("Clicks")]
        public int? Clicks { get; set; }
        [Column("Applicants")]
        public int Applicants { get; set; }
    }
}