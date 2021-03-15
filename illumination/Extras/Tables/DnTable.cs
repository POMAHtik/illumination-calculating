using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace illumination.Extras.Tables
{   
    
    static class DnTable
    {
        
        public class TableBase
        {
            public string N { get; set; }
            public bool isChecked { get; set; }
            public string Plane { get; set; }
            public string Room { get; set; }
            public double DhSer { get; set; } = -1;
            public double DhMin { get; set; } = -1;
            public double SumDhSer { get; set; } = -1;
            public double SumDhMin { get; set; } = -1;
            public bool isEnabled { get; set; } = true;
        }
 
        
        //Д1


        static public ObservableCollection<TableBase> Table1 = new ObservableCollection<TableBase>() //Адміністративні будинки
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - 0,8", Room = "Кабінети, робочі кімнати і офіси, приміщення для відвідувачів, експедиції, приміщення обслуговуючого персоналу", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "2", isChecked = false, Plane = "Г - 0,8", Room = "Проектні зали і кімнати, конструкторські, креслярські бюро", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "3", isChecked = false, Plane = "Г - 0,8", Room = "Макетні, столярні й ремонтні робочі майстерні", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "4", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення для роботи з дисплеями і відеотерміналами, дисплейні зали", DhSer = 3.5, DhMin = 1.2 },
            new TableBase() { N = "5", isChecked = false, Plane = "Г - 0,8", Room = "Конференц-зали, зали засідання", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "6", isChecked = false, Plane = "Г - 0,8", Room = "Читальні зали", DhSer = 3.5, DhMin = 1.2 },
            new TableBase() { N = "7", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення запису і реєстрації читачів, тематичних виставок, нових надходженнь", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "8", isChecked = false, Plane = "В - 1,0", Room = "Читацькі каталоги", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "9", isChecked = false, Plane = "Г - 0,8", Room = "Лінгафонні кабінети", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "10", isChecked = false, Plane = "Г - 0,8", Room = "Палітурно-брошурувальні приміщення площею більше 30м квадратних", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "11", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення для ксерокопіювання площею не більше 30м квадратних", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "12", isChecked = false, Plane = "Г - 0,8", Room = "Лабораторії: органічної і неорганічної хімії, термічні, фізичні, термографічні, спектрографічні, фотометричні, мікроскопні, рентгено-структурного аналізу, механічні та радіовимірювальні, електронних пристроїв, препараторські", DhSer = 3.5, DhMin = 1.2 },
            new TableBase() { N = "13", isChecked = false, Plane = "Г - 0,8", Room = "Аналітичні лабораторії", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "14", isChecked = false, Plane = "Г - 0,8", Room = "Мийні", DhSer = 3, DhMin = 1 }
        };

        static public ObservableCollection<TableBase> Table2 = new ObservableCollection<TableBase>() //Банківські та страхові установи
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - 0,8", Room = "Операційний зал, кредитна група, касовий зал, приміщення для перерахування грошей", DhSer = 3.5, DhMin = 1.2 }
        };

        static public ObservableCollection<TableBase> Table3 = new ObservableCollection<TableBase>() //Заклади дошкільної освіти
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - підлога", Room = "Роздягальні ясельних груп для дітей до 1-го року", DhSer = 3, DhMin = -1 },
            new TableBase(){ N = "2", isChecked = false, Plane = "Г - 0,8", Room = "Роздягальні ясельних груп для дітей від 1-го до 3-х років", DhSer = 3, DhMin = 1 },
            new TableBase(){ N = "3", isChecked = false, Plane = "Г - підлога", Room = "Роздягальні садових груп", DhSer = 3, DhMin = 1 },
            new TableBase(){ N = "4", isChecked = false, Plane = "Г - підлога", Room = "Ігрові, їдальні, зали для музичних і фізкультурних занять", DhSer = 4, DhMin = 1.5 },
            new TableBase(){ N = "5", isChecked = false, Plane = "Г - підлога", Room = "Спальні", DhSer = 2, DhMin = 0.5 },
            new TableBase(){ N = "6", isChecked = false, Plane = "Г - підлога", Room = "Туалетні кімнати", DhSer = 2.5, DhMin = 0.7 },
            new TableBase(){ N = "7", isChecked = false, Plane = "Г - підлога", Room = "Палати ізоляторів та приймально-карантинних відділень", DhSer = 4, DhMin = 1.5 },
        };

        static public ObservableCollection<TableBase> Table4 = new ObservableCollection<TableBase>() //Заклади середньої+ освіти
        {
            new TableBase(){ N = "1", isChecked = false, Plane = "В - 1,5 на середині дошки", Room = "Класні кімнати, аудиторії, навчальні кабінети, лабораторії закладів середньої освіти, професійно-технічних закладів", DhSer = 4, DhMin = 1.5 },
            new TableBase(){ N = "2", isChecked = false, Plane = "Г - 0,8 на робочих столах і партах", Room = "Класні кімнати, аудиторії, навчальні кабінети, лабораторії закладів середньої освіти, професійно-технічних закладів", DhSer = 4, DhMin = 1.5 },
            new TableBase(){ N = "3", isChecked = false, Plane = "В - 1,5 на середині дошки", Room = "Аудиторії, навчальні кабінети, лабораторії у вищих навчальних закладах", DhSer = 3.5, DhMin = 1.2 },
            new TableBase(){ N = "4", isChecked = false, Plane = "Г - 0,8 на робочих столах і партах", Room = "Аудиторії, навчальні кабінети, лабораторії у вищих навчальних закладах", DhSer = 3.5, DhMin = 1.2 },
            new TableBase(){ N = "5", isChecked = false, Plane = "Г - 0,8 на робочих столах і партах", Room = "Кабінети інформатики і обчислювальної техніки", DhSer = 3.5, DhMin = 1.2 },
            new TableBase(){ N = "6", isChecked = false, Plane = "В - на дошці", Room = "Кабінети технічного креслення та малювання", DhSer = 4, DhMin = 1.5 },
            new TableBase(){ N = "7", isChecked = false, Plane = "Г - 0,8 на столах і партах", Room = "Кабінети технічного креслення та малювання", DhSer = 4, DhMin = 1.5 },
            new TableBase(){ N = "8", isChecked = false, Plane = "Г - 0,8", Room = "Лаборантські при навчальних кабінетах", DhSer = 3.5, DhMin = 1.2 },
            new TableBase(){ N = "9", isChecked = false, Plane = "Г - 0,8", Room = "Інструментальна, кімната майстра інструктора", DhSer = 3, DhMin = 1 },
            new TableBase(){ N = "10", isChecked = false, Plane = "Г - 0,8", Room = "Кабінети обслуговуючих видів праці для дівчаток", DhSer = 4, DhMin = 1.5 },
            new TableBase(){ N = "11", isChecked = false, Plane = "Г - підлога", Room = "Спортивні, фізкультурно-спортивні зали", DhSer = 3, DhMin = 1 },
            new TableBase(){ N = "12", isChecked = false, Plane = "В - на рівні 2,0м від підлоги з обох\nсторін на поздовжній осі приміщення", Room = "Спортивні, фізкультурно-спортивні зали", DhSer = 1.2, DhMin = 0.3 },
            new TableBase(){ N = "13", isChecked = false, Plane = "Г - поверхня води", Room = "Криті басейни", DhSer = 3, DhMin = 1 },
            new TableBase(){ N = "14", isChecked = false, Plane = "Г - 0,8", Room = "Кабінети й кімнати викладачів", DhSer = 3, DhMin = 1 },
            new TableBase(){ N = "15", isChecked = false, Plane = "Г - підлога", Room = "Рекреації", DhSer = 2, DhMin = 0.4 }
        };

        static public ObservableCollection<TableBase> Table5 = new ObservableCollection<TableBase>() //Установи для дозвілля
        {

            new TableBase() { N = "1", isChecked = false, Plane = "Г - 0,8", Room = "Виставкові зали", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "2", isChecked = false, Plane = "Г - 0,8", Room = "Кімнати гуртків, музичні класи", DhSer = 3, DhMin = 1 }
        };

        static public ObservableCollection<TableBase> Table6 = new ObservableCollection<TableBase>() //Санаторії, бунки відпочинку
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - підлога", Room = "Виставкові зали", DhSer = 2, DhMin = 0.5 }
        };
        
        static public ObservableCollection<TableBase> Table7 = new ObservableCollection<TableBase>() //Фізкультурно-оздоровчі заклади
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - підлога", Room = "Зали спортивних ігор", DhSer = 3, DhMin = 1 },
            new TableBase(){ N = "2", isChecked = false, Plane = "В - 2,0 з обох сторін\nна поздовжній осі приміщення", Room = "Зали спортивних ігор", DhSer = 1.2, DhMin = 0.3 },
            new TableBase(){ N = "3", isChecked = false, Plane = "Г - поверхня води", Room = "Зал басейну", DhSer = 3, DhMin = 1 }
        };

        static public ObservableCollection<TableBase> Table8 = new ObservableCollection<TableBase>() //Підприємства харчування
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - 0,8", Room = "Обідні зали ресторанів, їдалень, кафе, барів", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "2", isChecked = false, Plane = "Г - 0,8", Room = "Мийні кухонного та столового посуду, приміщення для різання хліба, приміщення завідувача виробництва", DhSer = 2, DhMin = 0.5 }
        };
        
        static public ObservableCollection<TableBase> Table9 = new ObservableCollection<TableBase>() //Магазини
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - 0,8", Room = "Торгівельні зали магазинів: книжкових, готового одягу, білизни, взуття, тканин, хутряних виробів, головних уборів, парфумерних, галантерейних, ювелірних, електро-, радіотоварів, продовольчих товарів без самообслуговування", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "2", isChecked = false, Plane = "Г - 0,8", Room = "Торгівельні зали продовольчих магазинів з самообслуговуванням", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "3", isChecked = false, Plane = "Г - 0,8", Room = "Торгівельні зали магазинів: посуду, меблів, спортивних товарів, будматеріалів, електропобутових приладів, канцелярських товарів", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "4", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення відділів замовлень, бюро обслуговування", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "5", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення головних кас", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "6", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення для підготовки товарів до продажу", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "7", isChecked = false, Plane = "Г - 0,8", Room = "Майстерні підгонки готового одягу", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "8", isChecked = false, Plane = "Г - 0,8", Room = "Рекламно-декораційні майстерні, майстерні ремонту обладнання та інвентарю, приміщення брокерів", DhSer = 3, DhMin = 1 }
        };

        static public ObservableCollection<TableBase> Table10 = new ObservableCollection<TableBase>() //Підприємства побутового обслуговування
        {   
            new TableBase() { N = "1", isChecked = false, Plane = "Г - 0,8", Room = "Перукарні: чоловічий, жіночий зали", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "2", isChecked = false, Plane = "Г - 0,8", Room = "Перукарні: косметичний кабінет", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "3", isChecked = false, Plane = "Г - 0,8", Room = "Фотографії: салони прийому та видачі замовлень", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "4", isChecked = false, Plane = "Г - 0,8", Room = "Пральні: відділення прийому й видачі білизни - прийом з міткою та облік, видача", DhSer = 1, DhMin = 0.3 },
            new TableBase() { N = "5", isChecked = false, Plane = "Г - підлога", Room = "Пральні: пральні відділення - прання та готування розчинів", DhSer = 1, DhMin = 0.3 },
            new TableBase() { N = "6", isChecked = false, Plane = "Г - 0,8", Room = "Пральні: сушильно-прасуваньне відділення - механічні", DhSer = 1, DhMin = 0.3 },
            new TableBase() { N = "7", isChecked = false, Plane = "Г - 0,8", Room = "Пральні: сушильно-прасуваньне відділення - ручні", DhSer = 1, DhMin = 0.3 },
            new TableBase() { N = "8", isChecked = false, Plane = "Г - 0,8", Room = "Пральні: відділення сортування і упакування білизни", DhSer = 1, DhMin = 0.3 },
            new TableBase() { N = "9", isChecked = false, Plane = "Г - 0,8", Room = "Пральні: ремонт білизни", DhSer = 1, DhMin = 0.3 },
            new TableBase() { N = "10", isChecked = false, Plane = "Г - підлога", Room = "Пральнісамообслуговування", DhSer = 1, DhMin = 0.3 },
            new TableBase() { N = "11", isChecked = false, Plane = "Г - 0,8", Room = "Ательє хімічного чищення одягу: салон прийому та видачі одягу", DhSer = 1, DhMin = 0.3 },
            new TableBase() { N = "12", isChecked = false, Plane = "Г - 0,8", Room = "Ательє хімічного чищення одягу: приміщення хімічного очищення", DhSer = 1, DhMin = 0.3 },
            new TableBase() { N = "13", isChecked = false, Plane = "Г - 0,8", Room = "Ательє хімічного чищення одягу: відділення для видалення плям", DhSer = 1, DhMin = 0.3 },
            new TableBase() { N = "14", isChecked = false, Plane = "Г - 0,8 на робочих столах", Room = "Ательє виготовлення  й ремонту одягу і трикотажних виробів: пошивні цехи", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "15", isChecked = false, Plane = "Г - 0,8 на робочих столах", Room = "Ательє виготовлення  й ремонту одягу і трикотажних виробів: закрійні відділення", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "16", isChecked = false, Plane = "Г - 0,8", Room = "Ательє виготовлення  й ремонту одягу і трикотажних виробів: відділення ремонту одягу", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "17", isChecked = false, Plane = "Г - 0,8", Room = "Ательє виготовлення  й ремонту одягу і трикотажних виробів: відділення підготовки прикладних матеріалів", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "18", isChecked = false, Plane = "Г - 0,8", Room = "Ательє виготовлення  й ремонту одягу і трикотажних виробів: відділення ручного та машинного в'язання", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "19", isChecked = false, Plane = "Г - 0,8", Room = "Ательє виготовлення  й ремонту одягу і трикотажних виробів: прасувальні, декатирувальні", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "20", isChecked = false, Plane = "Г - 0,8", Room = "Пункти прокату: приміщення для відвідувачів", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "21", isChecked = false, Plane = "Г - 0,8", Room = "Ремонтні майстерні: виготовлення й ремонт головних уборів, кушнірські роботи", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "22", isChecked = false, Plane = "Г - 0,8", Room = "Ремонтні майстерні: ремонт взуття, галантереї, металовиробів, виробів із пластмаси, побутових електроприладів", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "23", isChecked = false, Plane = "Г - 0,8", Room = "Ремонтні майстерні: ремонт годинників, ювелірні і гравірувальні роботи", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "24", isChecked = false, Plane = "Г - 0,8", Room = "Ремонтні майстерні: ремонт фото-, кіно-, радіо- і телеапаратури", DhSer = 4, DhMin = 1.5 }    
        };

        static public ObservableCollection<TableBase> Table11 = new ObservableCollection<TableBase>() //Готелі
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - 0,8", Room = "Бюро обслуговування", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "2", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення чергового обслуговуючого персоналу", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "3", isChecked = false, Plane = "Г - 0,8", Room = "Вітальні номери", DhSer = 1, DhMin = 0.3 }
        };


        static public ObservableCollection<TableBase> Table12 = new ObservableCollection<TableBase>() //Заклади охорони здоров'я
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - 0,8", Room = "Родова, діапізаційні, реанімаційні зали, перев'язувальні", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "2", isChecked = false, Plane = "Г - 0,8", Room = "Кабінет ангіографії", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "3", isChecked = false, Plane = "Г - 0,8", Room = "Передопераційна", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "4", isChecked = false, Plane = "Г - 0,8", Room = "Монтажні апаратів штучного кровообігу, штучної нирки тощо", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "5", isChecked = false, Plane = "Г - 0,8", Room = "Кабінети хірургів, акушерів, гінекологів, травматологів, педіатрів, інфекціоністів, дерматологів, алергологів, стоматологів; оглядові, приймально-оглядові бокси", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "6", isChecked = false, Plane = "Г - 0,8", Room = "Кабінети лікарів в амбулаторно-поліклінічних закладах, які не навеені вище", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "7", isChecked = false, Plane = "Г - 0,8", Room = "Кабінети функціональної діагностики, ендоскопічні кабінети", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "8", isChecked = false, Plane = "Г - 0,8", Room = "Фотарії, кабінети фізіотерапії, масажу, лікувальної фізкультури", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "9", isChecked = false, Plane = "Г - 0,8", Room = "Кабінети: рентгено-бронхоскопії та лапароскопії", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "10", isChecked = false, Plane = "Г - 0,8", Room = "Кабінети: гідротерапії, лікувальні ванни, душові зали", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "11", isChecked = false, Plane = "Г - 0,8", Room = "Кабінети: трудотерапії", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "12", isChecked = false, Plane = "Г - 0,8", Room = "Кабінети флюорографії, рентгенівських знімків", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "13", isChecked = false, Plane = "Г - 0,8", Room = "Радіометрична, дозиметрична, кабінети випромінювання високих енергій, сканерна", DhSer = 3.5, DhMin = 1.2 },
            new TableBase() { N = "14", isChecked = false, Plane = "Г - 0,8", Room = "Кабінна гамма-терапії", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "15", isChecked = false, Plane = "Г - підлога", Room = "Палати: дитячих відділень, для новонароджених; інтенсивної терапії, післяопераційні, палати матері і дитини", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "16", isChecked = false, Plane = "Г - підлога", Room = "Інші палати та спальні", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "17", isChecked = false, Plane = "Г - 0,8", Room = "Лабораторії проведення аналізів, кабінети стереологічних досліджень, колориметричні", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "18", isChecked = false, Plane = "Г - 0,8", Room = "Препараторські, лаборантські загальноклінічних, гематологічних, біохімічних, бактеріологічних, гістологічних та цитологічних досліджень, коагулографії, фотометрії, вагова, термостатна, приготування поживних середовищ, приміщення для фарбування проб, центрифужна", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "19", isChecked = false, Plane = "Г - 0,8", Room = "Кабінети з кабінами зондування та взяття шлункового соку", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "20", isChecked = false, Plane = "Г - 0,8", Room = "Склодувна", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "21", isChecked = false, Plane = "Г - 0,8", Room = "Стерилізаційна, мийна", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "22", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення підготовки інструментів", DhSer = 3, DhMin = 1.2 },
            new TableBase() { N = "23", isChecked = false, Plane = "Г - 0,8", Room = "Секційна", DhSer = 3.5, DhMin = 1.2 },
            new TableBase() { N = "24", isChecked = false, Plane = "Г - 0,8", Room = "Передсекційна, фіксаційна", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "25", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення для оглядання трупів, траурний зал", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "26", isChecked = false, Plane = "Г - 0,8", Room = "Диспетчерські приміщення зберігання та видачі готових приманок, дезінфекційних засобів і бактерійних препаратів, фасувальні", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "27", isChecked = false, Plane = "Г - 0,8", Room = "Кімнати гельмінтологів, ентомологів, вірусологів, бактеріологів, лаборантські, хімічні, біохімічні лабораторії, серологічні, бокси, препараторські", DhSer = 3.5, DhMin = 1.2 },
            new TableBase() { N = "28", isChecked = false, Plane = "Г - 0,8", Room = "Радіологічні, радіохімічні, приміщення спектроскопії та полярографії, лабораторії акустики, вібрації, електромагнітних полів, фізіологічні праці, середоварильні з боксами, термітні", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "29", isChecked = false, Plane = "Г - 0,8", Room = "Мийні", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "30", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення взяття проб", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "31", isChecked = false, Plane = "Г - 0,8", Room = "Кімнати епідеміологів, бактеріологів, бокси серологічних досліджень особливо небезпечних інфекцій", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "32", isChecked = false, Plane = "Г - 0,8", Room = "Кімнати зоопаразитів", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "33", isChecked = false, Plane = "Г - 0,8", Room = "Біопробна, приміщення зберігання поживних середовищ, передбокси", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "34", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення дезкамер, стерильні цехи", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "35", isChecked = false, Plane = "Г - 0,8", Room = "Віварій. Приміщення для утримання тварин", DhSer = 3.5, DhMin = 1.2 },
            new TableBase() { N = "36", isChecked = false, Plane = "Г - 0,8", Room = "Диспетчерська", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "37", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення радіопосту", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "38", isChecked = false, Plane = "Г - 0,8", Room = "Кімната виїзинх бригад", DhSer = 2.5, DhMin = 0.7 },
            new TableBase() { N = "39", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення фільтрації та розливу", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "40", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення приготування та фасування продуктів", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "41", isChecked = false, Plane = "Г - 0,8", Room = "Процедурна, маніпуляційна", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "42", isChecked = false, Plane = "Г - 0,8", Room = "Кабінети, пости медичних сестер", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "43", isChecked = false, Plane = "Г - 0,8", Room = "Кімнати денного перебування, бесід з лікарем, годування дітей", DhSer = 2.5, DhMin = 0.7 }            
        };
        
        static public ObservableCollection<TableBase> Table13 = new ObservableCollection<TableBase>() //Вокзали
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - 0,8", Room = "Зали очікування", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "2", isChecked = false, Plane = "Г - 0,8", Room = "Операційні, касові, квиткові багажні каси, відділення зв'язку, операторська, диспетчерська", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "3", isChecked = false, Plane = "Г - 0,8", Room = "Обчислювальний центр", DhSer = 3.5, DhMin = 1.2 },
            new TableBase() { N = "4", isChecked = false, Plane = "Г - 0,8", Room = "Кімнати матері і дитини, тривалого перебування пасажирів", DhSer = 2.5, DhMin = 0.7 }
        };


        static public ObservableCollection<TableBase> Table14 = new ObservableCollection<TableBase>() //Інші приміщення виробничих,...
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - підлога", Room = "Санітарно-побутові приміщення: умивальні, туалети, курильні", DhSer = 1, DhMin = 0.3 },
            new TableBase() { N = "2", isChecked = false, Plane = "Г - підлога", Room = "Санітарно-побутові приміщення: душові, гардеробні приміщення для сушіння, обезпилювання і знешкодження одягу і взуття, приміщення для обігрівання працівників", DhSer = 1, DhMin = 0.3 },
            new TableBase() { N = "3", isChecked = false, Plane = "Г - підлога", Room = "Вестибюльні й гардеробні вуличного одягу", DhSer = 2, DhMin = 0.4 },
            new TableBase() { N = "4", isChecked = false, Plane = "Г - підлога", Room = "Вестибюльні й гардеробні вуличного одягу: у вишах, школах, театрах, гуртожитках, готелях і головних входах до великих виробничих підприємств та цивільних будівель", DhSer = 2, DhMin = 0.4 },
            new TableBase() { N = "5", isChecked = false, Plane = "Г - підлога\n(майданчики, сходи)", Room = "Сходи: головні сходові майданчики цивільних, виробничих та допоміжних будівель", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "6", isChecked = false, Plane = "Г - підлога", Room = "Сходи: інші сходові клітинки", DhSer = -1, DhMin = 0.1 },
            new TableBase() { N = "7", isChecked = false, Plane = "Г - підлога", Room = "Головні коридори і проходи", DhSer = -1, DhMin = 0.1 }
        };



        //Д2

        
        static public ObservableCollection<TableBase> Table15 = new ObservableCollection<TableBase>() //Станції технічного обслуговування транспорту
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - 0,8", Room = "Ділянки монтажу і ремонту шин, вулканізаційна ділянка", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "2", isChecked = false, Plane = "Г - 0,8", Room = "Ковальсько-ресорна ділянка", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "3", isChecked = false, Plane = "Г - 0,8", Room = "Зварювально-жерстяницька ділянка", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "4", isChecked = false, Plane = "Г - 0,8 (верстак)", Room = "Мідницька ділянка", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "5", isChecked = false, Plane = "Г - 0,8", Room = "Шпалерна ділянка", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "6", isChecked = false, Plane = "Г - 0,8", Room = "Кузовна ділянка", DhSer = 4, DhMin = 1.5 },
            new TableBase() { N = "7", isChecked = false, Plane = "Г - 0,8", Room = "Фарбувальна ділянка вантажних автомобілів, автобусів, трамваїв і тролейбусів", DhSer = 4, DhMin = 1.5 }
        };

        static public ObservableCollection<TableBase> Table16 = new ObservableCollection<TableBase>() //Електроприміщення
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення розподільних пристроїв диспетчерські, операторні (електрощитові)", DhSer = 4, DhMin = 1.5 }
        };

        static public ObservableCollection<TableBase> Table17 = new ObservableCollection<TableBase>() //Приміщення інженерних мереж
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - 0,8", Room = "Машинні зали насосних, повітродувні з постійним чергуванням персоналу", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "2", isChecked = false, Plane = "Г - 0,8", Room = "Генераторна", DhSer = 1, DhMin = 0.3 },
            new TableBase() { N = "3", isChecked = false, Plane = "Г - 0,8", Room = "Компресорні (блоки, станції, приміщення, зали) з постійним чергуванням персоналу", DhSer = 4, DhMin = 1.5 }
        };

        static public ObservableCollection<TableBase> Table18 = new ObservableCollection<TableBase>() //Склади
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - 0,8", Room = "Склади зі стелажним зберіганням: експедиція прийому і видачі багажу", DhSer = 4, DhMin = 1.5 }
        };

        static public ObservableCollection<TableBase> Table19 = new ObservableCollection<TableBase>() //Пожежні депо
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - підлога", Room = "Зона стоянки рухомого складу", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "2", isChecked = false, Plane = "Г - підлога", Room = "Пост технічного обслуговування", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "3", isChecked = false, Plane = "Г - 0,8", Room = "Приміщення зарядки регенеративних патронів", DhSer = 4, DhMin = 1.5 }
        };

        static public ObservableCollection<TableBase> Table20 = new ObservableCollection<TableBase>() //Районні управління з експлатації будівель
        {

        };

        //Д3

        static public ObservableCollection<TableBase> Table21 = new ObservableCollection<TableBase>() //Станції технічного обслуговування транспорту
        {
            new TableBase() { N = "1", isChecked = false, Plane = "Г - підлога", Room = "Житлові кімнати, вітальні, спальні, житлові кімнати гуртожитків", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "2", isChecked = false, Plane = "Г - 0,8", Room = "Кухні, кухні-їдальні", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "3", isChecked = false, Plane = "Г - підлога", Room = "Дитячі", DhSer = 2, DhMin = 0.7 },
            new TableBase() { N = "4", isChecked = false, Plane = "Г - 0,8", Room = "Кабінети, бібліотеки", DhSer = 3, DhMin = 1 },
            new TableBase() { N = "5", isChecked = false, Plane = "Г - поверхня води", Room = "Басейни", DhSer = 2, DhMin = 0.5 },
            new TableBase() { N = "6", isChecked = false, Plane = "Г - підлога", Room = "Загальнобудинкові приміщення: приміщення консьєржа", DhSer = 2, DhMin = 0.5 }
        };
    }
}
