using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Machine
    {
      public int MachineId { get; set; }
      
      [Required(ErrorMessage = "The machine's type can't be empty!")]
      public string Type { get; set; }

      [Required(ErrorMessage = "The machine's status can be operational, malfunctioning, or being repaired!")]
      public string Status { get; set; }

      [Required(ErrorMessage = "Please enter the machine inspection date!")]
      public DateTime InspectionDate  { get; set; }

      public List<EngineerMachine> JoinEntities { get;}

    }
}