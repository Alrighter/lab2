using System;

namespace lab2_7
{
    class employee{
        private string _name;
        private string _surname;
        private int _exp;
        private int _stage;

        private double taxes;
        private double slr;

        public void profileInfo(string name, string surname, int exp, int stage){
            this._name = name;
            this._surname = surname;
            this._exp = exp;
            this._stage = stage;
        }
        public void salaryCalc(){
            slr = 10000 + (1000 * _exp * (_stage + 1) * 0.9f);
            taxes = slr*0.15f;
        }
        public void showInfo(){
        Console.WriteLine($"\nИмя сотрудника: {_name}\nФамилия сотрудника: {_surname}\nДолжность: {_exp}\nОклад: {slr}\nНалоговый сбор: {taxes}");
        }
    }
}
