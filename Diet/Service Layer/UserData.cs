using Diet.Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diet.Service_Layer
{
    class UserData
    {
        public static void TotalCaloriesCount(int weight, int height, int age,
            RadioButton low, RadioButton normal, RadioButton average, RadioButton high, ProgressBar progress)
        {
            double total = 0, BMR = 0, ARM = 0;
            BMR = 447.593 + 9.247 * weight + 3.098 * height - 4.330 * age;
            Client.Weight = weight;
            Client.Height = height;
            Client.Age = age;
            if (low.Checked == true) { ARM = 1.2; Client.Activity = "Low"; }
            if (normal.Checked == true) { ARM = 1.375; Client.Activity = "Normal"; }
            if (average.Checked == true) { ARM = 1.55; Client.Activity = "Average"; }
            if (high.Checked == true) { ARM = 1.725; Client.Activity = "High"; }
            total = BMR * ARM;
            Client.TotalCalories = total;
            progress.Minimum = 0;
            progress.Maximum = Convert.ToInt32(total);
        }       
    }
}
