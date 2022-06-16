//How to summrize a long text
var sentence = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?";
var summary = SummarizeText(sentence);
Console.WriteLine(summary);


static string SummarizeText(string text, int maxLength = 20)
{
    if (text.Length < maxLength)
    { 
        return text;
    }
    var words = text.Split(" ");
    var totalChar = 0;
    var summaryWords = new List<string>();
    foreach (var word in words)
    {
            summaryWords.Add(word);
            totalChar += word.Length + 1; // we count the lenght of the words and add 1 becausew of the space
            if (totalChar > maxLength)
            
               break;

     }
    return String.Join(" ", summaryWords) + "...";

}


