using System.ComponentModel.DataAnnotations;

namespace AutoMapper.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
