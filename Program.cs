using System;

namespace ConsoleApp1
{
    abstract class factory
    {
        public abstract Create chainik();
        public abstract Create tarelka();
        public abstract Create chashka();

    }

    class Kzafactory : factory
    {
        public override Create chainik()
        {
            throw new NotImplementedException();
        }

        public override Create chashka()
        {
            throw new NotImplementedException();
        }

        public override Create tarelka()
        {
            throw new NotImplementedException();
        }
    }
    class IndiaFactory : factory
    {
        public override Create chainik()
        {
            throw new NotImplementedException();
        }

        public override Create chashka()
        {
            throw new NotImplementedException();
        }

        public override Create tarelka()
        {
            throw new NotImplementedException();
        }
    }

    class ChainaFcatory : factory
    {
        public override Create chainik()
        {
            throw new NotImplementedException();
        }

        public override Create chashka()
        {
            throw new NotImplementedException();
        }

        public override Create tarelka()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
     
        }
    }
}

//public interface ServizFactory { }

//public class ChinaFactory implements ServizFactory { }

//public class KazakhstanFactory implements ServizFactory { }

//public class IndiaFactory implements ServizFactory { }

//public interface ServizFactory
//{
//    Chainik createChainik();
//    Chashka createChashka();
//    Tarelka createTarelka();
//}

//public class ChinaFactory implements ServizFactory
//{
//    @Override
//    public Chainik createChainik()
//{
//    return new ChinaChainik();
//}

//@Override
//    public Chashka createChashka()
//{
//    return new ChinaChashka();
//}

//@Override
//    public Tarelka createTarelka()
//{
//    return new ChinaTarelka();
//}
//}

//public class KazakhstanFactory implements ServizFactory
//{
//    @Override

//    public Chainik createChainik()
//{
//    return new KazakhstanChainik();


//    @Override
//    public Chashka createChashka()
//    {
//        return new KazakhstanChashka();
//    }

//    @Override
//    public Tarelka createTarelka()
//    {
//        return new KazakhstanTarelka();
//    }


//public class IndiaFactory implements ServizFactory
//{
//    @Override

//    public Chainik createChainik()
//{
//    return new IndiaChainik();


//    @Override
//    public Chashka createChashka()
//    {
//        return new IndiaChashka();
//    }

//    @Override
//    public Tarelka createTarelka()
//    {
//        return new IndiaTarelka();
//    }



//public class ChinaChashka implements Chashka
//{
//    public ChinaChashka()
//{
//    System.out.println("Create ChinaChashka");
//}
//}

//public class ChinaChainik implements Chainik
//{
//    public ChinaChainik()
//{
//    System.out.println("Create ChinaChainik");
//}

//public class ChinaTarelka implements Tarelka
//{
//    public ChinaTarelka()
//{
//    System.out.println("Create ChinaTarelka");
//}
//}



//public class KazakhstanChashka implements Chashka
//{
//    public KazakhstanChashka()
//{
//    System.out.println("Create KazakhstanChashka");
//}
//}

//public class KazakhstanChainik implements Chainik
//{
//    public KazakhstanChainik()
//{
//    System.out.println("Create KazakhstanChainik");
//}

//public class KazakhstanTarelka implements Tarelka
//{
//    public KazakhstanTarelka()
//{
//    System.out.println("Create KazakhstanTarelka");
//}
//}



//public class IndiaChashka implements Chashka
//{
//    public IndiaChashka()
//{
//    System.out.println("Create IndiaChashka");
//}
//}

//public class IndiaChainik implements Chainik
//{
//    System.out.println("Create IndiaChainik");
//    public IndiaChainik()
//{
//}

//public class IndiaTarelka implements Tarelka
//{
//    public IndiaTarelka()
//{
//    System.out.println("Create IndiaTarelka");
//}
//}