using System;

namespace lab2_5
{
    public class user
    {
        private string  _login;
        private string  _name;
        private string  _surname;
        private int _age;
        private string _date;

        string login{get{return _login;} }
        string name{get{return _name;} }
        string surname{get{return _surname;} }
        int age {get {return _age;} }
        string date{get{return _date;} }

        public void profileFill(){

        }

        public void profileFill(string login, string name, string surname, int age, string date){
            this._login = login;
            this._name = name;
            this._surname = surname;
            this._age = age;
            this._date = date;
        }

        public void showProfile(){
            Console.WriteLine($"Login: {login}\nName: {name}\nSurname:{surname}\nAge: {age}\nDate: {date}");
        }
    }
}