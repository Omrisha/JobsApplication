using System.ComponentModel.DataAnnotations.Schema;

namespace JobsApplication
{
    [Table("Test_JobTitles")]
    public class JobTitleEntity
    {
        [Column("JobTitleId")]
        public int Id { get; set; }
        [Column("JobTitleName")]
        public string Name { get; set; }
        [Column("CategoryId")]
        public int CategoryId { get; set; }
    }
}