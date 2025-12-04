using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;
using Domain.Shared;

namespace Domain.TaskManagement;

public class TaskEntity : EntityBase<Guid>, IEntity
{
    [Required]
    [MinLength(3)]
    [MaxLength(100)]
    public string Title { get; internal set; } = string.Empty;
    
    [MaxLength(1000)]
    public string Description { get; internal set; } = string.Empty;
    
    public DateTime CreatedOn { get; internal init; }
    
    public Guid BoardId { get; internal init; }
    
    public TaskBoardEntity? Board { get; internal init; }
    
    public override List<ValidationResult> IsValid()
    {
        var validateResult = new List<ValidationResult>();
        
        Validator.TryValidateObject(this, new ValidationContext(this), validateResult, true);
        
        return validateResult;
    }
}