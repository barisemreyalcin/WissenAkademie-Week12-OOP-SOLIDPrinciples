// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//using DependncyInversion;

//IDatabase mssql = new MSSQLDatabase();
//ExceptionReporter reportSql = new ExceptionReporter(mssql);
//reportSql.addException(new Exception("SQL Exception"));


//IDatabase elk = new ElasticSearch();
//ExceptionReporter reportELK = new ExceptionReporter(elk);
//reportELK.addException(new Exception("ELK Exception"));



using DependncyInversion.DIP.ValidUsage.Abstract;
using DependncyInversion.DIP.ValidUsage.Concrete;

List<IUrun> liste = new List<IUrun>()
{ new Tavuk(),new Balik(),new Et() };    
Restoran restoran = new Restoran(liste);
restoran.YemekYap();


