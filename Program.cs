using DeliverySystem.Service;

try
{
    LoginScreen loginScreen = new();
    loginScreen.MainProgramm();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);

    Console.ReadLine();
}





