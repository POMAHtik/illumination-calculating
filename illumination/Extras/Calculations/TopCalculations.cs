using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace illumination.Extras.Calculations
{

    class TopCalculations
    {
        string LastAnswer;
    
        public double mGet(ref string Log)
        {
            double m = Tables.Tables.m_tab[MainClass.Region, 8];
            if (Log != null) Log += $"Коефіцієнт світлового клімату(m) {m}\n\tвизначений за регіоном {MainClass.Region + 1} і орієнтацією на азимут\n";
            return m;
        }
        
        public double nGet(int CountProgon, double HeightOfRoom, double LengthOfRoom, double WidthProgon, int selectedLight, ref string Log)
        {
            if (CountProgon > 3) CountProgon = 3;
            double relationHeightToLengthProgon = HeightOfRoom / WidthProgon;
            double relationLengthToLengthProgon = LengthOfRoom / WidthProgon;
            int indexY = 0;

            if (relationHeightToLengthProgon <= 0.4 && relationHeightToLengthProgon >= 0.2) indexY = 0;
            else if (relationHeightToLengthProgon <= 0.7 && relationHeightToLengthProgon > 0.4) indexY = 1;
            else if (relationHeightToLengthProgon <= 1 && relationHeightToLengthProgon > 0.7) indexY = 2;


            if (relationLengthToLengthProgon <= 2 && relationLengthToLengthProgon >= 1) indexY += 0;
            else if (relationLengthToLengthProgon <= 4 && relationLengthToLengthProgon > 2) indexY += 3;
            else if (relationLengthToLengthProgon > 4) indexY += 6;

            double Nl = Tables.Tables.nl1_tab[CountProgon - 1 + (selectedLight - 2) * 3, indexY];
            if (Log != null) Log += $"Коефіцієнт що враховує світлову активність ліхтарів(nл) {Nl}\n\tвідношення висоти кімнати до ширини прогону {relationHeightToLengthProgon}\n\tвідношення довжини кімнати до ширини прогону {relationLengthToLengthProgon}\n\n";
            return Nl;
        }

        public double nGet(double lp, double WidthOfRoom, double H, double s2, double s1, double sb, ref string Log)
        {
            double i = lp * WidthOfRoom / (H * (lp + WidthOfRoom));
            double s = s2 / (s1 + sb);
            int indexX, indexY;
            if (s <= 0.075) indexX = 0;
            else if (s <= 0.15) indexX = 1;
            else if (s <= 0.25) indexX = 2;
            else if (s <= 0.35) indexX = 3;
            else if (s <= 0.45) indexX = 4;
            else if (s <= 0.55) indexX = 5;
            else if (s <= 0.65) indexX = 6;
            else if (s <= 0.75) indexX = 7;
            else if (s <= 0.85) indexX = 8;
            else indexX = 9;

            if (i <= 0.6) indexY = 0;
            else if (i <= 0.85) indexY = 1;
            else if (i <= 1.125) indexY = 2;
            else if (i <= 1.375) indexY = 3;
            else if (i <= 1.75) indexY = 4;
            else if (i <= 2.25) indexY = 5;
            else if (i <= 2.75) indexY = 6;
            else if (i <= 3.5) indexY = 7;
            else if (i <= 4.5) indexY = 8;
            else indexY = 9;

            double Nl = Tables.Tables.nl2_tab[indexX, indexY];
            if (Log != null) Log += $"Коефіцієнт що враховує світлову активність ліхтарів(nл) {Nl}\n\tіндекс приміщення {i}\n\tвідношення площ {s}\n\n";
            return Nl;
        }

        public double r2Get(int CountProgon, double AverageCoefficient, double LengthToWindow, double WidthProgon, ref string Log)
        {
            double relationHeightToWindowToWidthProgon = LengthToWindow / WidthProgon;

            int indexX = 0, indexY = CountProgon - 1;

            if (relationHeightToWindowToWidthProgon <= 0.375 && relationHeightToWindowToWidthProgon >= 0) indexX = 0;
            else if (relationHeightToWindowToWidthProgon <= 0.625 && relationHeightToWindowToWidthProgon > 0.375) indexX = 1;
            else if (relationHeightToWindowToWidthProgon <= 1.5 && relationHeightToWindowToWidthProgon > 0.625) indexX = 2;
            else if (relationHeightToWindowToWidthProgon > 1.5) indexX = 3;

            if (AverageCoefficient > 0 && AverageCoefficient <= 0.35)
            {
                indexY += 6;
            }
            else if (AverageCoefficient <= 0.45)
            {
                indexY += 3;
            }
            else if (AverageCoefficient > 0.45)
            {
                indexY += 0;//Просто того шо можу
            }

            double r2 = Tables.Tables.r2_tab[indexX, indexY];
            if (Log != null) Log += $"Коефіцієнт що враховує світловідбивання(r2) {r2}\n\tвідношення висоти до нижньої границі засклення до ширини прогону {relationHeightToWindowToWidthProgon}\n\tкоефіцієнт світловідбивання {AverageCoefficient}\n\n";
            return r2;
        }

        public string Calculate(double Dh, double Kz, double Nl, double m, double t0, double r2, double Kl, double LengthOfRoom, double WidthOfRoom, ref string Log)
        {
            double S = ((Dh * Kz * Nl) / (100 * m * t0 * r2 * Kl)) * (LengthOfRoom * WidthOfRoom);
            if(Log != null) Log += $"Результат: S = {S}\n\tMin S(0.95): {S * 0.95}\n\tMax S(1.1) = {S * 1.1}\n\n";
            return LastAnswer =
                "Нормоване значення КПО (Dн) = " + Dh.ToString() + "\n" +
                "Коефіцієнт запасу (Kз) = " + Kz.ToString() + "\n" +
                "Коефіцієнт світлового клімату світлопрорізів (m) = " + m.ToString() + "\n" +
                "Коефіцієнт світлової активності ліхтарів (ηл) = " + Nl.ToString() + "\n" +
                "Коефіцієнт що враховує тип ліхтаря (Kл) = " + Kl.ToString() + "\n" +
                "Коефіцієнт підвищення КПО (r2) = " + r2.ToString() + "\n" +
                "Загальний коефіцієнт світлопропускання (τ0) = " + t0.ToString() + "\n" +
                "Ідеальне значення площі світлових прорізів (S) = " + S.ToString() + "\n" +
                "Мінімальне значення площі світлових прорізів (SMin) = " + S * 0.95 + "\n" +
                "Максимальне значення площі світлових прорізів (SMax) = " + S * 1.1 + "\n";
        }
    }
}
