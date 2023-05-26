
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }

    [Required(ErrorMessage = "The engineer's name can't be empty!")]
    public string Name { get; set; }
    public bool IsIdle { get; set; } = false;

    [Required]
    public DateTime LicenseDate { get; set; }
   
    public List<EngineerMachine> JoinEntities { get;}
  }
}