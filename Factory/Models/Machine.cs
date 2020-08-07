using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineers = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    
    [DisplayName("Date of Installation")]
    public DateTime Installation { get; set; }
    public virtual ICollection<EngineerMachine> Engineers { get; set; }
  }
}