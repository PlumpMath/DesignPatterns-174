namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var oradea = new OradeaPizzaShop();
            var cluj = new ClujPizzaShop();

            var margareta = oradea.OrderPizza("Margareta");

            var capricioasa = cluj.OrderPizza("Exotica");
        }
    }

    abstract class PizzaShop
    {
        public Pizza OrderPizza(string pizzaName)
        {
            var pizza = CreatePizza(pizzaName);

            pizza.Prepare();
            pizza.Bake();
            // do stuff with pizza

            return pizza;
        }

        protected abstract Pizza CreatePizza(string pizzaName);
    }

    class OradeaPizzaShop : PizzaShop
    {

        private readonly IngeridentFactory _ingeridentFactory;

        public OradeaPizzaShop()
        {
            _ingeridentFactory = new OradeaIngeridentFactory();
        }

        protected override Pizza CreatePizza(string pizzaName)
        {
            switch (pizzaName)
            {
                case "QuatroStagioni":
                    return new QuatroStagioniOradea(_ingeridentFactory);
                case "Margareta":
                    return new MargaretaOradea(_ingeridentFactory);
                case "Exotica":
                    return new ExoticaOradea(_ingeridentFactory);
                case "Capricioasa":
                    return new CapricioasaOradea(_ingeridentFactory);
            }

            return null;
        }
    }

    class ClujPizzaShop : PizzaShop
    {
        private readonly IngeridentFactory _ingeridentFactory;


        public ClujPizzaShop()
        {
            _ingeridentFactory = new ClujIngeridentFactory();
        }

        protected override Pizza CreatePizza(string pizzaName)
        {
            switch (pizzaName)
            {
                case "QuatroStagioni":
                    return new QuatroStagioniCluj(_ingeridentFactory);
                case "Margareta":
                    return new MargaretaCluj(_ingeridentFactory);
                case "Exotica":
                    return new ExoticaCluj(_ingeridentFactory);
                case "Capricioasa":
                    return new CapricioasaCluj(_ingeridentFactory);
            }

            return null;
        }
    }

    abstract class IngeridentFactory
    {
        public abstract Condimente CreateCondimente(string pizzaName);
        public abstract Aluat CreateAluat(string pizzaName);
        public abstract Bacon CreateBacon(string pizzaName);
    }

    class OradeaIngeridentFactory : IngeridentFactory
    {
        public override Condimente CreateCondimente(string pizzaName)
        {
            switch (pizzaName)
            {
                case "Exotica":
                    return new CondimenteOradea();
                case "Margareta":
                    return null;
            }
            return null;
        }

        public override Aluat CreateAluat(string pizzaName)
        {
            switch (pizzaName)
            {
                case "Exotica":
                    return new AluatOradea();
                case "Margareta":
                    return new AluatOradea();
            }
            return null;
        }

        public override Bacon CreateBacon(string pizzaName)
        {
            switch (pizzaName)
            {
                case "Exotica":
                    return new BaconOradea();
                case "Margareta":
                    return null;
            }
            return null;
        }
    }

    class ClujIngeridentFactory : IngeridentFactory
    {
        public override Condimente CreateCondimente(string pizzaName)
        {
            switch (pizzaName)
            {
                case "Exotica":
                    return null;
                case "Margareta":
                    return new CondimenteCluj();            
            }
            return null;
        }

        public override Aluat CreateAluat(string pizzaName)
        {
            switch (pizzaName)
            {
                case "Exotica":
                    return new AluatOradea();
                case "Margareta":
                    return new AluatCluj();
            }
            return null;
        }

        public override Bacon CreateBacon(string pizzaName)
        {
            switch (pizzaName)
            {
                case "Exotica":
                    return new BaconCluj();
                case "Margareta":
                    return null;
            }
            return null;
        }
    }


    abstract class Condimente
    {
        
    }

    class CondimenteOradea : Condimente
    {
        
    }

    class CondimenteCluj : Condimente
    {
        
    }

    abstract class Aluat
    {
        
    }

    class AluatOradea : Aluat
    {
        
    }

    class AluatCluj : Aluat
    {
        
    }
    abstract class Bacon
    {
        
    }

    class BaconOradea : Bacon
    {
        
    }

    class BaconCluj : Bacon
    {
        
    }

//    static class SimplePizzaFactory
//    {
//        public static Pizza CreatePizza(string pizzaName, string oras)
//        {
//            switch (oras)
//            {
//                case "Oradea":
//                    
//                    break;
//                case "Cluj":
//                    
//                    break;
//            }
//
//            return null;
//        }
//    }



    abstract class Pizza
    {
        public abstract string Name { get; set; }
        public abstract Condimente Condimente { get; set; }
        public abstract Aluat TipAluat { get; set; }

        public abstract void Prepare();
        public abstract void Bake();
    }

    class QuatroStagioniOradea : Pizza
    {
        private readonly IngeridentFactory _ingeridentFactory;

        public QuatroStagioniOradea(IngeridentFactory ingeridentFactory)
        {
            _ingeridentFactory = ingeridentFactory;
        }

        public override string Name { get; set; }
        public override Condimente Condimente { get; set; }
        public override Aluat TipAluat { get; set; }

        public override void Prepare()
        {
            Name = "QuatroStagioni";
            Condimente = _ingeridentFactory.CreateCondimente(Name);
            TipAluat = _ingeridentFactory.CreateAluat(Name);
        }

        public override void Bake()
        {
        }
    }

    class MargaretaOradea : Pizza
    {
        private readonly IngeridentFactory _ingeridentFactory;

        public MargaretaOradea(IngeridentFactory ingeridentFactory)
        {
            _ingeridentFactory = ingeridentFactory;
        }

        public override string Name { get; set; }
        public override Condimente Condimente { get; set; }
        public override Aluat TipAluat { get; set; }

        public override void Prepare()
        {
            Name = "Margareta";
            Condimente = _ingeridentFactory.CreateCondimente(Name);
            TipAluat = _ingeridentFactory.CreateAluat(Name);
        }

        public override void Bake()
        {
        }
    }
    class ExoticaOradea : Pizza
    {
        private readonly IngeridentFactory _ingeridentFactory;

        public ExoticaOradea(IngeridentFactory ingeridentFactory)
        {
            _ingeridentFactory = ingeridentFactory;
        }

        public override string Name { get; set; }
        public override Condimente Condimente { get; set; }
        public override Aluat TipAluat { get; set; }

        public override void Prepare()
        {
            Name = "Exotica";
            Condimente = _ingeridentFactory.CreateCondimente(Name);
            TipAluat = _ingeridentFactory.CreateAluat(Name);
        }

        public override void Bake()
        {
        }
    }
    class CapricioasaOradea : Pizza
    {
        private readonly IngeridentFactory _ingeridentFactory;

        public CapricioasaOradea(IngeridentFactory ingeridentFactory)
        {
            _ingeridentFactory = ingeridentFactory;
        }

        public override string Name { get; set; }
        public override Condimente Condimente { get; set; }
        public override Aluat TipAluat { get; set; }

        public override void Prepare()
        {
            Name = "CapricioasaOradea";
            Condimente = _ingeridentFactory.CreateCondimente(Name);
            TipAluat = _ingeridentFactory.CreateAluat(Name);
        }

        public override void Bake()
        {
        }
    }

    class QuatroStagioniCluj : Pizza
    {
        private readonly IngeridentFactory _ingeridentFactory;

        public QuatroStagioniCluj(IngeridentFactory ingeridentFactory)
        {
            _ingeridentFactory = ingeridentFactory;
        }

        public override string Name { get; set; }
        public override Condimente Condimente { get; set; }
        public override Aluat TipAluat { get; set; }

        public override void Prepare()
        {
            Name = "QuatroStagioniCluj";
            Condimente = _ingeridentFactory.CreateCondimente(Name);
            TipAluat = _ingeridentFactory.CreateAluat(Name);
        }

        public override void Bake()
        {
        }
    }

    class MargaretaCluj : Pizza
    {
        private readonly IngeridentFactory _ingeridentFactory;

        public MargaretaCluj(IngeridentFactory ingeridentFactory)
        {
            _ingeridentFactory = ingeridentFactory;
        }

        public override string Name { get; set; }
        public override Condimente Condimente { get; set; }
        public override Aluat TipAluat { get; set; }

        public override void Prepare()
        {
            Name = "MargaretaCluj";
            Condimente = _ingeridentFactory.CreateCondimente(Name);
            TipAluat = _ingeridentFactory.CreateAluat(Name);
        }

        public override void Bake()
        {
        }
    }
    class ExoticaCluj : Pizza
    {
        private readonly IngeridentFactory _ingeridentFactory;

        public ExoticaCluj(IngeridentFactory ingeridentFactory)
        {
            _ingeridentFactory = ingeridentFactory;
        }

        public override string Name { get; set; }
        public override Condimente Condimente { get; set; }
        public override Aluat TipAluat { get; set; }

        public override void Prepare()
        {
            Name = "Exotica";
            Condimente = _ingeridentFactory.CreateCondimente(Name);
            TipAluat = _ingeridentFactory.CreateAluat(Name);
        }

        public override void Bake()
        {
        }
    }
    class CapricioasaCluj : Pizza
    {
        private readonly IngeridentFactory _ingeridentFactory;

        public CapricioasaCluj(IngeridentFactory ingeridentFactory)
        {
            _ingeridentFactory = ingeridentFactory;
        }

        public override string Name { get; set; }
        public override Condimente Condimente { get; set; }
        public override Aluat TipAluat { get; set; }

        public override void Prepare()
        {
            Name = "CapricioasaCluj";
            Condimente = _ingeridentFactory.CreateCondimente(Name);
            TipAluat = _ingeridentFactory.CreateAluat(Name);
        }

        public override void Bake()
        {
        }
    }
}