using System;
using System.ComponentModel.DataAnnotations;

namespace DemoEntityFramework.Models;

public class Class
{
    [Key]
    public int Id { get; set; }
    public string ClassName { get; set; }
    public string RoomName { get; set; }
}
