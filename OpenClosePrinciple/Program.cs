// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using OpenClosePrinciple;


//Employee employee = new Employee()
//{
//    EmployeID = 1,
//    FirstName = "John",
//    LastName = "Doe",
//    Email = "john.doe@contoso.com"
//};

////MSSQL DB
//IDatabase dbMSSQL = new MSSQLDatabase();
//EmployeeManager employeeManager = new EmployeeManager(dbMSSQL);
//employeeManager.addEmployee(employee);

//Console.ReadLine();

////Oracle DB
//IDatabase dbOracle = new OracleDatabase();
//EmployeeManager empManagerOracle = new EmployeeManager(dbOracle);
//empManagerOracle.addEmployee(employee);



using OpenClosePrinciple.OCP;

///Araba Durumu
///
Araba araba = new Araba("Kırmızı");
BildirimServisi.ArabanınDurumunuVer(araba);

ElektirkliDepoServisi elektrikliDepoServisi = new ElektirkliDepoServisi();
elektrikliDepoServisi.SarjEt(araba);

MotorServisi motorServisi = new MotorServisi(elektrikliDepoServisi);
motorServisi.MotorCalistir(araba);
BildirimServisi.ArabanınDurumunuVer(araba);

motorServisi.MotorDurdur(araba);
BildirimServisi.ArabanınDurumunuVer(araba);

