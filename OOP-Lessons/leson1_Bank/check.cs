using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lessons.leson1_Bank
{

    public enum CheckTipe
    {
        Classic = 1,
        salary = 2,
        credit =3

    }

    public class Check
    {
        private int _idcheck;//№Счета
        private double _balance;//Баланс
        private CheckTipe _tipe;//Тип счета    


        public Check()
        {
            _idcheck = 10000;

            _balance = 0;

            _tipe = 0; //Почемуто 0 можно, а int уже нельзя //_tipe = (CheckTipe)tipe;
        }

        public Check(int idcheck, double balanse, int tipe)
        {
            _idcheck = idcheck;
            _balance = balanse;
            _tipe = (CheckTipe)tipe;

        }

        public int idcheck
        {
            get
            {
                return _idcheck;
            }
            set
            {
                _idcheck = value;
            }
        }

        public double balanse
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }


    }
}
