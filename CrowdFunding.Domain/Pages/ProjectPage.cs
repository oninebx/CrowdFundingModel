using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFunding.Domain.Pages
{
    public class ProjectPage : Page
    {
        public required decimal TargetAmount { get; set; }

    public override PageType Type => PageType.Project;
  }
}