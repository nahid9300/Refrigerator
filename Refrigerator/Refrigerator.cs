using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator
{
    class Refrigerator
    {
        private string maximumWeight { get; set; }
        private string itemsNo { get; set; }
        private string itemWeight { get; set; }

        public void MaximumWeight(string maximumWeight)
        {
            this.maximumWeight = maximumWeight;
        }

        public void NumberOfItem(string itemsNo)
        {
            this.itemsNo = itemsNo;
        }

        public void ItemsWeight(string itemWeight)
        {
            this.itemWeight = itemWeight;
        }

        public string GetCurrentWeight()
        {
            int currentWeight = Convert.ToInt32(itemsNo) * Convert.ToInt32(itemWeight);
            return currentWeight.ToString();
        }

        public string GetRemainingWeight()
        {
            int remainingWeight = Convert.ToInt32(maximumWeight) - Convert.ToInt32(GetCurrentWeight());
            return remainingWeight.ToString();
        }
    }
}
