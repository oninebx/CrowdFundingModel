using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFunding.Domain.Pages
{
    public class FundraiserPage : Page
    {
        public required ICollection<Page> TargetPages { get; set; }

    public override PageType Type => PageType.Fundraiser;
  }
}