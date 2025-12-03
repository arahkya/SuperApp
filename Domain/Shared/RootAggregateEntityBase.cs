using System.ComponentModel.DataAnnotations;

namespace Domain.Shared;

public abstract class RootAggregateEntityBase<TKey> : EntityBase<TKey> 
    where TKey : IEquatable<TKey> 
{
    public override List<ValidationResult> IsValid()
    {
        return [];
    }
}