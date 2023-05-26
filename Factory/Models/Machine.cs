using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
    {
      public int MachineId { get; set; }
      
      [Required(ErrorMessage = "The machine's type can't be empty!")]
      public string Type { get; set; }

      [Required(ErrorMessage = "The machine's status can be "operational", or"malfunctioning", or "being repaired"!")]
      public string Status { get; set; }

      public List<EngineerMachine> JoinEntities { get;}

    }
}