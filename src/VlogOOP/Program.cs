using VlogOOP;

List<Promoter> promoters = new List<Promoter>()
{
    new XSClubPromoter("Jon", "Jones", 09135101092),
    new XSClubPromoter("Jim", "Jones", 09135101093),
    new OmniaClubPromoter("Jane", "Jones", 09135101094)
};

List<Writer> writers = new List<Writer>()
{
    new BookWriter("Jon", "Jones"),
    new BookWriter("Jim", "Jones"),
    new BlogWriter("Jane", "Jones")
};

List<IBodyBuilder> bodyBuilders = new List<IBodyBuilder>()
{
    new XSClubPromoter("Jon", "Jones", 09135101092),
    new XSClubPromoter("Jim", "Jones", 09135101093)
};

List<IVlogger> vloggers = new List<IVlogger>()
{
    new BookWriter("Jon", "Jones"),
    new BlogWriter("Jim", "Jones")
};


foreach (var promoter in promoters)
{
    promoter.Promote();
}

foreach (var writer in writers)
{
    writer.Write();
}

foreach (var bodyBuilder in bodyBuilders)
{
    bodyBuilder.WorkOut();
}

foreach (var vlogger in vloggers)
{
    vlogger.Vlog();
}

Console.ReadKey();
