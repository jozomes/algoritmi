using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

public class PermutationGenerator
{
   

    public static void Main()
    {
        string s = "Ova recenica ce biti uokvirena zvijezdicama";
        string[] niz = s.Split(' ');
        int max = 0;
        foreach (string el in niz)
        {
            if (el.Length > max)
            {
                max = el.Length;
            }
        }

        string okvir = new string('*', max+2); //okvir mora prekrit cijelu rijec + po jedan sa obe strane
        string rjesenje = "";
        foreach (string item in niz)
        {
            int broj = item.Length - 2; //zbog poklapanja granica
            string dodatak = new string(' ', ((max-2) - broj)); //opet moramo 'izbiti' po jedan space sa strane kako bi nam se granice poklapale
            string ele = '*' + item + dodatak + '*';
            rjesenje += ele + '\n';
        }
        string finalno = okvir + '\n' + rjesenje + okvir;
        Console.WriteLine(finalno);
        Console.ReadLine();
    }
}