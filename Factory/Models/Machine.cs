using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
    {
      public int MachineId { get; set; }
      public string Type { get; set; }

      [Range(1, int.MaxValue, ErrorMessage = "You must add your machine to a engineer. Have you added a engineer yet?")]
      public List<EngineerMachine> JoinEntities { get;}

    }
}