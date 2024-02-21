using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerBlazorEF.Models;

public class Course {
    public string? Code  { get; set; }
    [Required]
    public string? Title  { get; set; }
    [Required]
    public string? Location  { get; set; }
    [Required]
    public string? Instructor   { get; set; }
}
