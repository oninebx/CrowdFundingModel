using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFunding.Domain.Pages
{
  public abstract class Page
  {
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Pitch { get; set; }
    public required string Description { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
  }
}