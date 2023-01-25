using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Model
{
    public class AssetsDetail
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
