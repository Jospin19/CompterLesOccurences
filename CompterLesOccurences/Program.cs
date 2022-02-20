string text = @"Historically, the world of data and the world of objects" +
          @" have not been well integrated. Programmers work in C# or Visual Basic" +
          @" and also in SQL or XQuery. On the one side are concepts such as classes," +
          @" objects, fields, inheritance, and .NET APIs. On the other side" +
          @" are tables, columns, rows, nodes, and separate languages for dealing with" +
          @" them. Data types often require translation between the two worlds; there are" +
          @" different standard functions. Because the object world has no notion of query, a" +
          @" query can only be represented as a string without compile-time type checking or" +
          @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
          @" objects in memory is often tedious and error-prone.";

string TermeARechercher = "data";

//Convertit la chaine de caractère en tableau de mot
string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

// Création de la requête.  Use ToLowerInvariant pour faire correspondre "data" et "Data"
var RequeteDeRecherche = from mot in source
                 where mot.ToLowerInvariant() == TermeARechercher.ToLowerInvariant()
                 select mot;

// Count the matches, which executes the query.  
int OccurenceMot = RequeteDeRecherche.Count();
Console.WriteLine("{0} occurrences(s) du terme recherche \"{1}\" ont été trouvés.", OccurenceMot, TermeARechercher);

// Keep console window open in debug mode  
Console.WriteLine("Press any key to exit");
Console.ReadKey();

//IsDigit savoir s'il s'agit d'un chiffre
// var diffrenece = names2.Except(name1) 


/*
* Savoir si une chaine contient un symbole espace en l'occurence
*/
// return str.Any(c => !char.IsLetterOrDigit(' ')); 

