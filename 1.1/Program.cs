// See https://aka.ms/new-console-template for more information


    var random = new Random();
    const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    string randomString = string.Empty;

    for (int i = 0; i < 5; i++) 
    {
        char charToAdd = characters[random.Next(characters.Length)];
        randomString += charToAdd.ToString();
    }
while (true)
{
    Console.WriteLine(randomString);
    Console.WriteLine(DateTime.Now);
    System.Threading.Thread.Sleep(5000);
}

