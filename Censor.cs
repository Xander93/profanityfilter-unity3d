using UnityEngine;
using System;
using System.Text.RegularExpressions;

public class Censor : MonoBehaviour
{
    private string input = "foo word bar word2 foobar another akakkaak cyka blyat";
    private string pattern = @"\b(?:word|cyka|word2|another)\b";
    private string result;

    void Start() {
        result = Regex.Replace(input, pattern, m => new String('*', m.Length));
        print(result);
    }
}