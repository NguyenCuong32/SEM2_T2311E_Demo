using System;
using DemoEntityFramework.Models;

namespace DemoEntityFramework.Services;

public interface IClassService
{
    List<Class> GetClasses();
}
