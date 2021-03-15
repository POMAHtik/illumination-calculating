using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace illumination.Extras.Tables
{
    class KzTable
    {
        public class TableBase
        {
            public string N { get; set; }
            public bool isChecked { get; set; }
            public string Dust { get; set; }
            public double[] Coefficient { get; set; }
        }

        static public ObservableCollection<TableBase> Table1 = new ObservableCollection<TableBase>() //Виробничі приміщення з повітряним середовищем
        {
            new TableBase { N = "1", isChecked = false, Dust = "більш, ніж 5 мг/м^3 пилу, диму, кіптяви", Coefficient = new double[4]{2, 1.8, 1.7, 1.5 } },
            new TableBase { N = "2", isChecked = false, Dust = "від 1 до 5 мг/м^3 пилу, диму, кіптяви", Coefficient = new double[4]{1.8, 1.6, 1.5, 1.4 } },
            new TableBase { N = "3", isChecked = false, Dust = "менше ніж 1 мг/м^3 пилу, диму, кіптяви", Coefficient = new double[4]{1.6, 1.5, 1.4, 1.3 } },
            new TableBase { N = "4", isChecked = false, Dust = "великі концентрації пари, кислоти, лугів, газів, спроможних при зіткненні з вологою утворювати слабкі розчини кислот, лугів, а також які мають велику корозійну спроможність", Coefficient = new double[4]{2, 1.8, 1.7, 1.5} }
        };

        static public ObservableCollection<TableBase> Table2 = new ObservableCollection<TableBase>() //Виробничі приміщення з повітряним середовищем
        {
            new TableBase { N = "1", isChecked = false, Dust = "запилені з високою температурою, високою вологістю", Coefficient = new double[4]{2, 1.8, 1.7, 1.6 }  },
            new TableBase { N = "2", isChecked = false, Dust = "з нормальними умовами середовища", Coefficient = new double[4]{1.5, 1.4, 1.3, 1.2 } }
        };
    }
}
