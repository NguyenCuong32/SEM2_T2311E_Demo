using System;
using DemoEntityFramework.Models;

namespace DemoEntityFramework.Repositories;

public interface IClassRepository
{
    List<Class> GetClasses();
}
