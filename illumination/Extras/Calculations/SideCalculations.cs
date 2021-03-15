using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace illumination.Extras.Calculations
{
    class SideCalculations
    {
        string LastAnswer;

        private int getIndexForAzimuth(double Azimuth)
        {
            if (((Azimuth >= 0) && (Azimuth <= 22.5)) || ((Azimuth > 337.5) && (Azimuth <= 360)))
                return 0;
            else if ((Azimuth > 22.5) && (Azimuth <= 67.5))
                return 1;
            else if ((Azimuth > 67.5) && (Azimuth <= 112.5))
                return 2;
            else if ((Azimuth > 112.5) && (Azimuth <= 157.5))
                return 3;
            else if ((Azimuth > 157.5) && (Azimuth <= 202.5))
                return 4;
            else if ((Azimuth > 202.5) && (Azimuth <= 247.5))
                return 5;
            else if ((Azimuth > 247.5) && (Azimuth <= 292.5))
                return 6;
            else if ((Azimuth > 292.5) && (Azimuth <= 337.5))
                return 7;
            return -1;
        }

        public double mGet(double Azimuth, int Region, ref string Log) //для одностороннього
        {
            int Index = getIndexForAzimuth(Azimuth);
            double m = Tables.Tables.m_tab[Region, Index];
            if (Log != null) Log += $"Коефіцієнт світлового клімату(m) {m}\n\tвизначений за регіоном {MainClass.Region + 1}\n\tі орієнтацією на сторону {Index + 1}\n\n";
            return m;
        }

        public double mGet(double AzimuthA, double AzimuthB, int Region, ref string Log) //для одностороннього
        {

            double m1 = Tables.Tables.m_tab[Region, getIndexForAzimuth(AzimuthA)];
            double m2 = Tables.Tables.m_tab[Region, getIndexForAzimuth(AzimuthB)];
            double ms = 2 * m1 * m2 / (m1 + m2);

            if (Log != null) Log += $"Середній коефіцієнт світлового клімату(m): {ms}\n\tвизначений за коефіцієнтом(m1): {m1}\n\tі коефіцієнтом(m2): {m2}\n\n";
            return ms;
        }

        public double nGet(double LengthOfBuilding, double WidthOfBuilding, double LengthToWindow, ref string Log)
        {
            double relationLengthToWidth = LengthOfBuilding / WidthOfBuilding;
            double relationWidthtoLendth = WidthOfBuilding / LengthToWindow;
            int indexX = 0, indexY = 0;

            if (relationLengthToWidth <= 0.75 && relationLengthToWidth >= 0) indexX = 5;
            else if (relationLengthToWidth <= 1.25 && relationLengthToWidth > 0.75) indexX = 4;
            else if (relationLengthToWidth <= 1.75 && relationLengthToWidth > 1.25) indexX = 3;
            else if (relationLengthToWidth <= 2.5 && relationLengthToWidth > 1.75) indexX = 2;
            else if (relationLengthToWidth <= 3.5 && relationLengthToWidth > 2.5) indexX = 1;
            else if (relationLengthToWidth > 3.5) indexX = 0;

            if (relationWidthtoLendth <= 1.25 && relationWidthtoLendth >= 0) indexY = 0;
            else if (relationWidthtoLendth <= 1.75 && relationWidthtoLendth > 1.25) indexY = 1;
            else if (relationWidthtoLendth <= 2.5 && relationWidthtoLendth > 1.75) indexY = 2;
            else if (relationWidthtoLendth <= 3.5 && relationWidthtoLendth > 2.5) indexY = 3;
            else if (relationWidthtoLendth <= 4.5 && relationWidthtoLendth > 3.5) indexY = 4;
            else if (relationWidthtoLendth <= 6.25 && relationWidthtoLendth > 4.5) indexY = 5;
            else if (relationWidthtoLendth <= 8.75 && relationWidthtoLendth > 6.25) indexY = 6;
            else if (relationWidthtoLendth > 8.75) indexY = 7;
            
            double n = Tables.Tables.n_tab[indexX, indexY];
            if (Log != null) Log += $"Коефіцієнт що враховує світлову активність вікон(nв) {n}\n\tвідношення довжини приміщення до ширини приміщення {relationLengthToWidth}\n\tвідношення ширини приміщення до відстані до верхньої частини вікна {relationWidthtoLendth}\n\n";
            return n;
        }

        public double r1Get(double WidthOfBuilding, double LengthToWindow, double LengthFromWindowToPoint, double AverageCoefficient, ref string Log)
        {
            double relationWidthtoLendth = WidthOfBuilding / LengthToWindow;
            double relationLengthFromWindowToPointToWidth = LengthFromWindowToPoint / WidthOfBuilding;

            int indexX = 0, indexY = 0, tmp = 0;

            if (relationWidthtoLendth <= 1.5 && relationWidthtoLendth >= 0) tmp = 0;
            else if (relationWidthtoLendth <= 2.5 && relationWidthtoLendth > 1.5) tmp = 1;
            else if (relationWidthtoLendth <= 3.5 && relationWidthtoLendth > 2.5) tmp = 2;
            else if (relationWidthtoLendth > 3.5) tmp = 3;

            switch (tmp)
            {
                case 0:
                    if (relationLengthFromWindowToPointToWidth <= 0.3 && relationLengthFromWindowToPointToWidth >= 0) indexX = 0;
                    else if (relationLengthFromWindowToPointToWidth <= 0.75 && relationLengthFromWindowToPointToWidth > 0.3) indexX = 1;
                    else if (relationLengthFromWindowToPointToWidth > 0.75) indexX = 2;
                    break;
                case 1:
                    if (relationLengthFromWindowToPointToWidth <= 0.2 && relationLengthFromWindowToPointToWidth >= 0) indexX = 3;
                    else if (relationLengthFromWindowToPointToWidth <= 0.4 && relationLengthFromWindowToPointToWidth > 0.2) indexX = 4;
                    else if (relationLengthFromWindowToPointToWidth <= 0.6 && relationLengthFromWindowToPointToWidth > 0.4) indexX = 5;
                    else if (relationLengthFromWindowToPointToWidth <= 0.85 && relationLengthFromWindowToPointToWidth > 0.6) indexX = 6;
                    else if (relationLengthFromWindowToPointToWidth > 0.85) indexX = 7;
                    break;
                case 2:
                    if (relationLengthFromWindowToPointToWidth <= 0.15 && relationLengthFromWindowToPointToWidth >= 0) indexX = 8;
                    else if (relationLengthFromWindowToPointToWidth <= 0.25 && relationLengthFromWindowToPointToWidth > 0.15) indexX = 9;
                    else if (relationLengthFromWindowToPointToWidth <= 0.35 && relationLengthFromWindowToPointToWidth > 0.25) indexX = 10;
                    else if (relationLengthFromWindowToPointToWidth <= 0.45 && relationLengthFromWindowToPointToWidth > 0.35) indexX = 11;
                    else if (relationLengthFromWindowToPointToWidth <= 0.55 && relationLengthFromWindowToPointToWidth > 0.45) indexX = 12;
                    else if (relationLengthFromWindowToPointToWidth <= 0.65 && relationLengthFromWindowToPointToWidth > 0.55) indexX = 13;
                    else if (relationLengthFromWindowToPointToWidth <= 0.75 && relationLengthFromWindowToPointToWidth > 0.65) indexX = 14;
                    else if (relationLengthFromWindowToPointToWidth <= 0.85 && relationLengthFromWindowToPointToWidth > 0.75) indexX = 15;
                    else if (relationLengthFromWindowToPointToWidth <= 0.95 && relationLengthFromWindowToPointToWidth > 0.85) indexX = 16;
                    else if (relationLengthFromWindowToPointToWidth > 0.95) indexX = 17;
                    break;
                case 3:
                    if (relationLengthFromWindowToPointToWidth <= 0.15 && relationLengthFromWindowToPointToWidth >= 0) indexX = 18;
                    else if (relationLengthFromWindowToPointToWidth <= 0.25 && relationLengthFromWindowToPointToWidth > 0.15) indexX = 19;
                    else if (relationLengthFromWindowToPointToWidth <= 0.35 && relationLengthFromWindowToPointToWidth > 0.25) indexX = 20;
                    else if (relationLengthFromWindowToPointToWidth <= 0.45 && relationLengthFromWindowToPointToWidth > 0.35) indexX = 21;
                    else if (relationLengthFromWindowToPointToWidth <= 0.55 && relationLengthFromWindowToPointToWidth > 0.45) indexX = 22;
                    else if (relationLengthFromWindowToPointToWidth <= 0.65 && relationLengthFromWindowToPointToWidth > 0.55) indexX = 23;
                    else if (relationLengthFromWindowToPointToWidth <= 0.75 && relationLengthFromWindowToPointToWidth > 0.65) indexX = 24;
                    else if (relationLengthFromWindowToPointToWidth <= 0.85 && relationLengthFromWindowToPointToWidth > 0.75) indexX = 25;
                    else if (relationLengthFromWindowToPointToWidth <= 0.95 && relationLengthFromWindowToPointToWidth > 0.85) indexX = 26;
                    else if (relationLengthFromWindowToPointToWidth > 0.95) indexX = 27;
                    break;
                default:
                    return -1;
            }

            if (AverageCoefficient > 0.45) indexY = 0;
            if (AverageCoefficient > 0.35 && AverageCoefficient <= 0.45) indexY = 3;
            if (AverageCoefficient >= 0 && AverageCoefficient <= 0.35) indexY = 6;
            
            if (relationWidthtoLendth <= 0.75 && relationWidthtoLendth >= 0) indexY += 0;
            else if (relationWidthtoLendth < 2 && relationWidthtoLendth > 0.75) indexY += 1;
            else if (relationWidthtoLendth >= 2) indexX += 2;

            double r1 = Tables.Tables.r1_tab[indexX, indexY];
            if (Log != null) Log += $"Коефіцієнт підвищення КПО(r1) {r1}\n\tвідношення ширини приміщення до відстані від робочої поверхні до верху вікна {relationWidthtoLendth}\n\tвідношення відстані до розрахункової точки до ширини приміщення {relationLengthFromWindowToPointToWidth}\n\tкоефіцієнт світловідбивання {AverageCoefficient}\n\n";
            return r1;
        }

        public double KbudGet(double LengthToNeighbourBuilding, double HeightOfNeighbourBuilding, ref string Log)
        {
            double Kbud = -1;
            
            if (LengthToNeighbourBuilding == 0 || HeightOfNeighbourBuilding == 0)
            {
                Kbud = 1; 
                if (Log != null) Log += $"Коефіцієнт затінювання вікон (Kбуд): {Kbud}\n\tчерез те, що, або відстань до сусіднього будинку = 0, або його висота = 0\n\n";
                return Kbud;
            }
            
            double relation = LengthToNeighbourBuilding / HeightOfNeighbourBuilding;
            if (relation <= 0.75 && relation >= 0) Kbud = 1.7;
            else if (relation <= 1.25 && relation > 0.75) Kbud = 1.4;
            else if (relation <= 1.75 && relation > 1.25) Kbud = 1.2;
            else if (relation <= 2.5 && relation > 1.75) Kbud = 1.1;
            else if (relation > 2.5) Kbud = 1;
            

            if (Log != null) Log += $"Коефіцієнт затінювання вікон (Kбуд): {Kbud}\n\tвідношення відстані до сусіднього будинку і його висоти: {relation}\n\n"; 
            return Kbud; 
        }

        public string Calculate(double Dh, double Kz, double Nb, double Kbud, double m, double t0, double r1, double LengthOfBuilding, double WidthOfBuilding, ref string Log)
        {
            double S = ((Dh * Kz * Nb * Kbud) / (100.0 * m * t0 * r1)) * (LengthOfBuilding * WidthOfBuilding);
            if(Log != null)Log += $"Результат: S = {S}\n\tMin S(0.95): {S * 0.95}\n\tMax S(1.1) = {S * 1.1}\n\n";

            return
               "Нормоване значення КПО (Dн) = " + Dh.ToString() + "\n" +
               "Коефіцієнт запасу (Kз) = " + Kz.ToString() + "\n" +
               "Коефіцієнт світлового клімату світлопрорізів (m) = " + m.ToString() + "\n" +
               "Коефіцієнт світлової активності вікон (ηв) = " + Nb.ToString() + "\n" +
               "Коефіцієнт затінювання вікон (Kбуд) = " + Kbud.ToString() + "\n" +
               "Коефіцієнт підвищення КПО (r1) = " + r1.ToString() + "\n" +
               "Загальний коефіцієнт світлопропускання (τ0) = " + t0.ToString() + "\n" +
               "Ідеальне значення площі світлових прорізів (S) = " + S.ToString() + "\n" +
               "Мінімальне значення площі світлових прорізів (SMin) = " + S * 0.95 + "\n" +
               "Максимальне значення площі світлових прорізів (SMax) = " + S * 1.1 + "\n";
        }
    }
}
