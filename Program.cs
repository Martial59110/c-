﻿
using Data;
using CsvHelper;
using System.IO;
using System.Globalization;
using meth;



namespace MyApp;

internal class Program
{


    static void Main(string[] args)
    {
        

        Random random = new Random();
        Quizz d = new Quizz();
        Methodes m = new Methodes();
        string userInputLow;

        do
        {
            Console.WriteLine("Tapez 1 pour choisir un quiz aléatoire, tapez 2 pour choisir une catégorie, et tapez 3 pour quitter l'application.");
            userInputLow = m.UserLower();
            Console.Clear();
            if (userInputLow == "1" || userInputLow == "2" || userInputLow == "3")
            {
                switch (userInputLow)
                {
                    case "1":
                        m.NombreAleatoire = random.Next(1, 6);
                        userInputLow = m.NombreAleatoire.ToString();
                        break;
                    case "2":
                        Console.WriteLine("Liste des quiz : \n 1) Sport \n 2) Littérature \n 3) Technologie \n 4) Sciences \n 5) Gastronomie ");
                        userInputLow = m.UserLower();
                        Console.Clear();
                        break;
                    case "3":
                        m.IfExit();
                        return;
                }

                m.SetThemeQuizz(m, userInputLow);

                Console.WriteLine($"La catégorie sélectionné est {m.ThemeQuizz}");
                switch (m.ThemeQuizz)
                {
                    case "Sport":
                        m.ProcessQuiz(d.SportPrincipal, d.SportSecondaire, d.SportNumber);
                        return;

                    case "Langues et littérature":
                        m.ProcessQuiz(d.LanguePrincipal, d.LangueSecondaire, d.LangueNumber);
                        return;

                    case "Technologie et informatique":
                        m.ProcessQuiz(d.TechnologiePrincipal, d.TechnologieSecondaire, d.TechnologieNumber);
                        return;

                    case "Sciences et nature":
                        m.ProcessQuiz(d.SciencesPrincipal, d.SciencesSecondaire, d.SciencesNumber);
                        return;

                    case "Cuisine et gastronomie":
                        m.ProcessQuiz(d.CuisinePrincipal, d.CuisineSecondaire, d.CuisineNumber);
                        return;

                }
            }
            else
            {
                Console.WriteLine("Entrée non valide, veuillez choisir 1, 2 ou 3");
            }
        } while (true);
    }

   
}