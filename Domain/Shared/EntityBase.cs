using System.ComponentModel.DataAnnotations;

namespace Domain.Shared;

public abstract class EntityBase<TKey> where TKey : IEquatable<TKey>
{
    public TKey? Id { get; init; }

    public abstract List<ValidationResult> IsValid();
}