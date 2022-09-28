
#region First Try Catch

// try
// {
    
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(a);
//     Console.ReadKey();
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error" + ex.Message);
    
// }
// finally{
//     Console.WriteLine("Program has completed");
// }
#endregion

#region Second Try Catch

try
{
    string numAsText = Console.ReadLine(); // read line waiting a number as a text in console.
    int b = int.Parse(numAsText); // parse is converting string to int.
    Console.WriteLine("İnput: {0} and output: {1}",numAsText,b+120);
    
    
}
catch (ArgumentNullException ex)
{
    
    Console.WriteLine("You've entred a null value");
    Console.WriteLine(ex);
}
finally{
    Console.WriteLine("Program's ended.");
}



#endregion
