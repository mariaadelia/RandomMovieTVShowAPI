using System;
using System.Collections.Generic;
using System.IO;

namespace MovieProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //Transformar isso aqui em uma API que possa ler essas informações (Transformar em um JSON) e transformar em dados de um banco de dados (mock) e aí fazer a parte de um tipo/número randomico
            //  com a sugestão do filme/serie (ver se a pessoa que filme ou série e depois fazer essa parte)

            string csvFile = "C:/Users/mdcampos/Documents/Projects/MovieProject/dataset/movies_metadata.csv";

            //To read the CSV FIle
            StreamReader reader = new StreamReader(File.OpenRead(csvFile));

            List<String> moviesList = new List<String>();
            
            while (!reader.EndOfStream)
            {
                var lines = reader.ReadLine();
                var values = lines.Split(',');

                foreach (var item in values)
                {
                    moviesList.Add(item);
                }
            }         

            Console.WriteLine(moviesList[1]);



            Console.ReadLine();
        }
    }
}
