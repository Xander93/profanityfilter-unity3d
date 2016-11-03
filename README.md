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
