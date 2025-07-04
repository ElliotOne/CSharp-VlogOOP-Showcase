namespace VlogOOP
{
    public class XSClubPromoter : Promoter, IVlogger, IBodyBuilder
    {
        public XSClubPromoter(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
        {
        }

        protected override void ShareWithInnerCircle()
        {
            Console.WriteLine("I share with my Instagram followers.");
        }

        protected override void UsePaidAds()
        {
            Console.WriteLine("I use Facebook ads.");
        }

        public void Vlog()
        {
            Console.WriteLine("I use a DSLR in order to vlog.");
        }

        public void WorkOut()
        {
            Console.WriteLine("I work out at my house.");
        }
    }
}
