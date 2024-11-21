using System;
using DemoEntityFramework.Models;

namespace DemoEntityFramework.Repositories;

public class ClassRepository : IClassRepository
{
    private readonly EduDbContext dbContext;

    public ClassRepository(EduDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public List<Class> GetClasses()
    {
        return this.dbContext.Classes.ToList();
    }
}
