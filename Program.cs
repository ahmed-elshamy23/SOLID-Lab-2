using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Task_3;
using Unity;

namespace Lab_2
{
    internal class Program
    {
        static void Main()
        {
            // Castle Windsor
            var container = new WindsorContainer();
            container.Register(Component.For<ICreditCard>().ImplementedBy<MasterCard>());

            // Unity
            var container2 = new UnityContainer();
            container2.RegisterType<ICreditCard, VisaCard>();

            // Testing
            var shopper = new Shopper();
            var shopper2 = new Shopper();
            shopper.Checkout(container.Resolve<ICreditCard>());
            shopper2.Checkout(container2.Resolve<ICreditCard>());
        }
    }
}
