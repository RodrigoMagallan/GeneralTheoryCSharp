//usefull methods to work with string
//Conv a string to a number
string str = "1234";
int i = int.Parse(str); //if the string is null or empty this method returns an exception
int j = Convert.ToInt32(str); //if the string is null or empty this method returns and integer = 0
//Conv a number to string
int d = 1234;
string ss = d.ToString(); // "1234"
string t = d.ToString("C"); // "$1,234.00" Formant string
string t1 = d.ToString("C0"); // "$1,234"   formats specifier (c or C for currency), (d or D for Decimal), (e or E for exponential), (f or F for fixed point), (x or X for hexadecimal)

//Formatting strings
//ToLower() ToUpper() Trim()
var fullName = "Rodrigo Magallan ";
Console.WriteLine("Trim: '{0}'", fullName.Trim()); //'Rodrigo Magallan' no spaces
Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper()); //'RODRIGO MAGALLAN ' with space at the end becasue string are inmutables if we want to delete the space we should use fullName.Trim().ToUpper()

//Searching
//IndexOf() LastIndexOf
var index = fullName.IndexOf(' '); //we are getting the index of the space 

//Substring 
//Substring(startIndex) Substring(startIndex, length)
var firstName = fullName.Substring(0, index); //Sbstring from the beggingin until the space (variable index)
var lastName = fullName.Substring(index + 1); //Substring from the space + 1 to the end of the string
Console.WriteLine("FirstName = " + firstName); // FirstName = Rodrigo
Console.WriteLine("LastName = " + lastName); //Lastname = Magallan

//Splitting
//str.Split(' ')
var names = fullName.Split(' '); // splitting by space into an array 
Console.WriteLine("FirstName: " + names[0]);  // FirstName: Rodrigo
Console.WriteLine("LastName: " + names[1]); //Lastname: Magallan

//Replacing
//Replace('a', '!') 
Console.WriteLine("FullName modified: " + fullName.Replace("Rodrigo", "Roy"));  //Replaceing my name by my nickname Roy also we can use replace to replace only a word
 
//Null checking\
//String.IsNullOrEmpty(str)  String.IsNullOrWhiteSpace(str)

if(String.IsNullOrEmpty("")) //We are passing a empty string so the message in de console will be Invalid the same works if we pass Null  String.IsNullOrEmpty(Null) if we put a space the message won't be displayedso this is where we can use trim as String.IsNullOrEmpty(" ").Trim(). all this can be replaced with the method IsNullOrWhiteSpace :3
    Console.WriteLine("Invalid");

if(String.IsNullOrWhiteSpace(" "))
    Console.WriteLine("Invalid");


