using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBackUIApplication.models
{
    public class FeedBackModel
    {

        public bool PurchaseMade { get; set; }


        public bool SatifactedWithQuality { get; set; }

    public DateTime VisitDate { get; set; }

public string Experience{ get; set; }

    public string Recommendation{ get; set; }
    }
}
