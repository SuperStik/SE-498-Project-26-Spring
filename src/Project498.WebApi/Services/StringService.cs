namespace Project498.WebApi.Services;

public class StringService : IStringService
{
    public string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        var charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    
    public string ReverseWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return "";

        var sb = new System.Text.StringBuilder();
        var i = input.Length - 1;
        while (i >= 0)
        {
            while (i >= 0 && input[i] == ' ') i--;
            if (i < 0) break;
            var end = i;
            while (i >= 0 && input[i] != ' ') i--;
            var start = i + 1;
            for (var j = start; j <= end; j++) sb.Append(input[j]);
            if (i > 0) sb.Append(' ');
        }
        return sb.ToString();
    }
}
