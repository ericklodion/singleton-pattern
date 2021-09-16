using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.Singleton.ConsoleApp
{
    class Singleton
    {
        //Previne que outras classes chamem o operador "new"
        private Singleton(){}

        private static Singleton _singleton;

        //Garante que sempre a mesma instância será retornada
        public static Singleton GetInstance()
        {
            if (_singleton is null)
                _singleton = new Singleton();

            return _singleton;
        }
    }
}
