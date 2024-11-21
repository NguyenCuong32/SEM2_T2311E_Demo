using System;
using DemoEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoEntityFramework.Repositories;

public class EduDbContext:DbContext
{
    public EduDbContext():base()
    {
        
    }
    public EduDbContext(DbContextOptions<EduDbContext> options):base(options)
    {
        
    }
    public DbSet<Class> Classes { get; set; }
}
