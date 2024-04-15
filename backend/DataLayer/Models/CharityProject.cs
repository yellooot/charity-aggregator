using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models;

public class CharityProject
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProjectId { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    public string Description { get; set; }

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }

    [ForeignKey("Charity")]
    public int CharityId { get; set; }
    public Charity Charity { get; set; }

    public List<ProjectPhoto> ProjectPhotos { get; set; }
    public List<ProjectComment> ProjectComments { get; set; }
    public List<ProjectCategoryMapping> ProjectCategoryMappings { get; set; }
}