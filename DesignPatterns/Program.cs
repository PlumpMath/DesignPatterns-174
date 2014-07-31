namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var oradea = new OradeaPizzaShop();
            var cluj = new ClujPizzaShop();

            var margareta = oradea.OrderPizza("Margareta");

            var capricioasa = cluj.OrderPizza("Capricioasa");
        }
    }

    abstract class PizzaShop
    {
        public Pizza OrderPizza(string pizzaName)
        {
            var pizza = CreatePizza(pizzaName);

            pizza.Bake();
            // do stuff with pizza

            return pizza;
        }

        protected abstract Pizza CreatePizza(string pizzaName);
    }

    class OradeaPizzaShop : PizzaShop
    {
        protected override Pizza CreatePizza(string pizzaName)
        {
            switch (pizzaName)
            {
                case "QuatroStagioni":
                    return new QuatroStagioniOradea();
                case "Margareta":
                    return new MargaretaOradea();
                case "Exotica":
                    return new ExoticaOradea();
                case "Capricioasa":
                    return new CapricioasaOradea();
            }

            return null;
        }
    }

    class ClujPizzaShop : PizzaShop
    {
        protected override Pizza CreatePizza(string pizzaName)
        {
            switch (pizzaName)
            {
                case "QuatroStagioni":
                    return new QuatroStagioniCluj();
                case "Margareta":
                    return new MargaretaCluj();
                case "Exotica":
                    return new ExoticaCluj();
                case "Capricioasa":
                    return new CapricioasaCluj();
            }

            return null;
        }
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
        public abstract void Bake();
    }

    class QuatroStagioniOradea : Pizza
    {
        public override void Bake()
        {
            throw new System.NotImplementedException();
        }
    }

    class MargaretaOradea : Pizza
    {
        public override void Bake()
        {
            throw new System.NotImplementedException();
        }
    }
    class ExoticaOradea : Pizza
    {
        public override void Bake()
        {
            throw new System.NotImplementedException();
        }
    }
    class CapricioasaOradea : Pizza
    {
        public override void Bake()
        {
            throw new System.NotImplementedException();
        }
    }

    class QuatroStagioniCluj : Pizza
    {
        public override void Bake()
        {
            throw new System.NotImplementedException();
        }
    }

    class MargaretaCluj : Pizza
    {
        public override void Bake()
        {
            throw new System.NotImplementedException();
        }
    }
    class ExoticaCluj : Pizza
    {
        public override void Bake()
        {
            throw new System.NotImplementedException();
        }
    }
    class CapricioasaCluj : Pizza
    {
        public override void Bake()
        {
            throw new System.NotImplementedException();
        }
    }
}