using System.ComponentModel.DataAnnotations;

namespace WebApplication.RazorPages.Persistence.Entities;

public class Person
{
    public int Id { get; set; }
    public string FullName { get; set; }
    [MaxLength(250)]
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsAlive { get; set; }
    public int JobId { get; set; }
    public Job Job { get; set; }
}