using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<EngineerMachine>();
    }
    public int EngineerId { get; set; }
    public string Name { get; set; }
    
    [DisplayName("Hire Date")]
    public DateTime HireDate { get; set; }
    public virtual ICollection<EngineerMachine> Machines { get; set; }
  }
}