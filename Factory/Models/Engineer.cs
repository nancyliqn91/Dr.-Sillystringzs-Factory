
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }

    [Required(ErrorMessage = "The engineer's name can't be empty!")]
    public string Name { get; set; }
    public bool IsIdle { get; set; } = false;
    
    public List<EngineerMachine> JoinEntities { get;}
  }
}