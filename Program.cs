using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
   
    abstract class servize
    {
        public abstract Product1 chainik();
        public abstract Product3 tarelka();
        public abstract Product2 chashka();
    
    }

    class KazakhstanFactory : servize
    {
        public override Product1 chainik()
        {
            return new Chainik();
            
        }

        public override Product2 chashka()
        {
            return new Chashka();
        }

        public override Product3 tarelka()
        {
            return new Tarelka();
        }
    }

    class ChainaFactory : servize
    {
        public override Product1 chainik()
        {

            return new Chainik();
        }

        public override Product2 chashka()
        {
            return new Chashka();
        }

        public override Product3 tarelka()
        {
            return new Tarelka();
        }
    }

    class IndiaFactory : servize
    {
        public override Product1 chainik()
        {

            return new Chainik();
        }

        public override Product2 chashka()
        {
            return new Chashka();
        }

        public override Product3 tarelka()
        {
            return new Tarelka();
        }
    }

    abstract class Product1 { }
    abstract class Product2 { }
    abstract class Product3 { }
    class Chainik : Product1 { }
    class Chashka : Product2 { }
    class Tarelka : Product3 { }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    
}




