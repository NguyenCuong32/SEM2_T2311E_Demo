using System;
using DemoEntityFramework.Models;
using DemoEntityFramework.Repositories;

namespace DemoEntityFramework.Services;

public class ClassService : IClassService
{
    private readonly IClassRepository classRepository;

    public ClassService(IClassRepository classRepository)
    {
        this.classRepository = classRepository;
    }
    public List<Class> GetClasses()
    {
        return this.classRepository.GetClasses();
    }
}
