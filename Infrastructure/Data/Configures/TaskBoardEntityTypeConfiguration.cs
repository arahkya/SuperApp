using Domain.TaskManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configures;

public class TaskBoardEntityTypeConfiguration : IEntityTypeConfiguration<TaskBoardEntity>
{
    public void Configure(EntityTypeBuilder<TaskBoardEntity> builder)
    {
        builder.ToTable("TaskBoards");
        builder.HasKey(x => x.Id);
        builder.HasMany(x => x.Tasks).WithOne(p => p.Board).HasForeignKey(p => p.BoardId).IsRequired();

        builder.HasData([
            new TaskBoardEntity
            {
                Id = Guid.Parse("4969A039-C082-44AD-A9A4-0EFE2BBA3DE3")
            }
        ]);
    }
}