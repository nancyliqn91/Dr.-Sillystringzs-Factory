namespace PN.Models
{
  public class EngineerMachine
    {       
        public int EngineerMachineId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "You must add your engineer to a machine. Have you added a machine yet?")]        
        public int EngineerId { get; set; }
        public Engineer Engineer { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "You must add your machine to a engineer. Have you added a engineer yet?")]
        public int MachineId { get; set; }
        public Machine Machine { get; set; }
    }
}