# unity3d-profanityfilter
A basic profanity filter.

## you can use this on many ways, this is one of them:
~~~
        string forbiddenWords = @"\b(?:test1|test2|test3|test4)\b";
        bool nameNotOke = Regex.IsMatch(textName.text, forbiddenWords);

        if (nameNotOke)
        {
            return;
        }
~~~

## you can use a txt file if you don't like a hughe string in your code:
~~~
public TextAsset forbiddenWords;

string forbiddenWordsString = @"\b(?:";
        string[] seperators = { "\n", " " };
        string[] words;

        words = forbiddenWords.text.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            if (i < words.Length - 1)
            {
                forbiddenWordsString += words[i] + "|";
            } else {
                forbiddenWordsString += words[i];
            }

        }
        forbiddenWordsString += @")\b";
        forbiddenWordsString = Regex.Replace(forbiddenWordsString, @"\t|\n|\r", "");
        
        bool nameNotOke = Regex.IsMatch(textName.text.ToLower(), forbiddenWordsString.ToLower());
~~~
