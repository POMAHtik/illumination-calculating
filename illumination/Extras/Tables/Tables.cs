﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace illumination.Extras.Tables
{
    class Tables
    {
        static public double[,] m_tab = new double[4, 9]
           {
            {1.93,0.96,1.00,1.02,1.03,1.02,1.01,0.96, 0.99},
            {1.05,1.09,1.14,1.16,1.18,1.17,1.15,1.09, 1.12},
            {1.07,1.12,1.18,1.22,1.23,1.22,1.20,1.12, 1.17},
            {1.15,1.21,1.28,1.32,1.33,1.32,1.29,1.21, 1.26}
           };


        static public double[,] n_tab = new double[6, 8] // бокове освітлення
        {
            {6.5,7,7.5,8,9,10,11,12.5},
            {7.5,8,8.5,9.6,10,11,12.5,14},
            {8.5,9,9.5,10.5,11.5,13,15,17},
            {9.5,10.5,13,15,17,19,21,23},
            {11,15,16,18,21,23,26.5,29},
            {18,23,31,37,45,54,66,-1}
        };

        static public double[,] nl1_tab = new double[12, 9] // верхнє освітлення для трапецевидних, прямокутних
        {
            {5.8, 9.4, 16, 4.6, 6.8, 10.5, 4.4, 6.4, 9.1},
            {5.2, 7.5, 12.8, 4, 5.1, 7.8, 3.7, 6.4, 6.5},
            {4.8, 6.7, 11.4, 3.8, 4.5, 6.9, 3.4, 4, 5.6},

            {3.5, 5.2, 6.2, 2.8, 3.8, 4.7, 2.7, 3.6, 4.1},
            {3.2, 4.4, 5.3, 2.5, 3, 4.1, 2.3, 2.7, 3.4},
            {3, 4, 4.7, 2.35, 2.7, 3.7, 2.1, 2.4, 3},

            {6.4, 10.5, 15.2, 5.1, 7.6, 10, 4.9, 7.1, 8.5},
            {6.1, 8, 11, 4.7, 5.5, 6.6, 4.35, 5, 5.5},
            {5, 6.5, 8.2, 4, 4.3, 5, 3.6, 3.8, 4.1},

            {3.8, 4.55, 6.8, 2.9, 3.4, 4.5, 2.5, 3.2, 3.9},
            {3, 4.3, 5.7, 2.3, 2.9, 2.5, 2.15, 2.65, 2.9},
            {2.7, 3.7, 5.1, 2.2, 2.5, 3.1, 2, 2.25, 2.5}
        };

        static public double[,] nl2_tab = new double[10, 10] // верхнє освітлення
        {
            {25, 19, 16, 14.3, 13.3, 12, 11.5, 11, 10.5, 10},
            {13, 10.3, 8.5, 7.7, 7, 6.3, 6, 5.8, 5.5, 5.4},
            {7, 5.6, 4.6, 4.2, 3.8, 3.4, 3.3, 3.1, 3, 2.9},
            {5, 4, 3.3, 2.9, 2.7, 2.4, 2.3, 2.2, 2.1, 2},
            {4.2, 3.3, 2.7, 2.4, 2.2, 2, 1.9, 1.85, 1.8, 1.7},

            {3.7, 2.9, 2.4, 2.1, 2, 1.8, 1.7, 1.6, 1.55, 1.5},
            {3.3, 2.6, 2.1, 1.9, 1.8, 1.6, 1.5, 1.45, 1.4, 1.3},
            {3.1, 2.4, 2, 1.8, 1.6, 1.5, 1.4, 1.35, 1.3, 1.25},
            {2.9, 2.3, 1.9, 1.7, 1.55, 1.4, 1.35, 1.3, 1.2, 1.2},
            {2.8, 2.2, 1.8, 1.6, 1.5, 1.35, 1.3, 1.25, 1.2, 1.15}
        };


        static public double[,] r1_tab = new double[28, 9]
        {
            {1.05, 1.05, 1.05, 1.05, 1.05, 1, 1.05, 1, 1},
            {1.4,1.3,1.2,1.2,1.15,1.1,1.2,1.1,1.1},
            {2.1,1.9,1.5,1.8,1.6,1.3,1.4,1.3,1.2},
            {1.05,1.05,1.05,1.05,1.05,1.05,1.05,1,1},
            {1.3,1.2,1.1,1.2,1.15,1.1,1.15,1.1,1.05},
            {1.85,1.6,1.3,1.5,1.35,1.2,1.3,1.2,1.1},
            {2.25,2,1.7,1.7,1.6,1.3,1.55,1.35,1.2},
            {3.8,3.3,2.4,2.8,2.4,1.8,2,1.8,1.5},
            {1.1,1.05,1.05,1.05,1,1,1,1,1},
            {1.15,1.1,1.05,1.1,1.1,1.05,1.05,1.05,1.05},
            {1.2,1.15,1.1,1.15,1.1,1.1,1.1,1.1,1.05},
            {1.35,1.25,1.2,1.2,1.15,1.1,1.15,1.1,1.1},
            {1.6,1.45,1.3,1.35,1.25,1.2,1.25,1.15,1.1},
            {2,1.75,1.45,1.6,1.45,1.3,1.4,1.3,1.2},
            {2.6,2.2,1.7,1.9,1.7,1.4,1.6,1.5,1.3},
            {3.6,3.1,2.4,2.4,2.2,1.55,1.9,1.7,1.4},
            {5.3,4.2,3,2.9,2.45,1.9,2.2,1.85,1.5},
            {7.2,5.4,4.3,3.6,3.1,2.4,2.6,2.2,1.7},
            {1.2,1.15,1.1,1.1,1.1,1.05,1.05,1.05,1},
            {1.4,1.3,1.2,1.2,1.15,1.1,1.1,1.05,1.05},
            {1.75,1.5,1.3,1.4,1.3,1.2,1.25,1.2,1.1},
            {2.4,2.1,1.8,1.6,1.4,1.3,1.4,1.3,1.2},
            {3.4,2.9,2.5,2,1.8,1.5,1.7,1.5,1.3},
            {4.6,3.8,3.1,2.4,2.1,1.8,2,1.8,1.5},
            {6,4.7,3.7,2.9,2.6,2.1,2.3,2,1.7},
            {7.4,5.8,4.7,3.4,2.9,2.4,2.6,2.3,1.9},
            {9,7.1,5.6,4.3,3.6,3,3,2.6,2.1},
            {10,7.3,5.7,5,4.1,3.5,3.5,3,2.5}
        };

        static public double[,] r2_tab = new double[5, 9]
        {
            {1.7, 1.5, 1.15, 1.6, 1.4, 1.1, 1.4, 1.1, 1.05},
            {1.5, 1.4, 1.15, 1.4, 1.3, 1.1, 1.3, 1.1, 1.05},
            {1.45, 1.35, 1.15, 1.35, 1.25, 1.1, 1.25, 1.1, 1.05 },
            {1.4, 1.3, 1.15, 1.3, 1.2, 1.1, 1.2, 1.1, 1.05 },
            {1.35, 1.25, 1.15, 1.25, 1.15, 1.1, 1.15, 1.1, 1.05 }
        };
    }
}