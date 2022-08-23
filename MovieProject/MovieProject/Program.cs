using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Conversion;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GenerateJsonDataSet
{
    class Program
    {
        static void Main(string[] args)
        {

            // Converter arquivo CSV para o formato JSON em C #
            var loadOptions = new CsvLoadOptions
            {
                Separator = ','
            };

            using (Converter converter = new Converter(@"/Users/mariaadelia/Desktop/Programação/ProjectsCSharp/DataSetMovieProject/movies_metadata.csv",
                    () => loadOptions))
            {
                DataConvertOptions options = new DataConvertOptions
                {
                    Format = DataFileType.Json
                };
                converter.Convert(@"/Users/mariaadelia/Desktop/Programação/ProjectsCSharp/MovieProject/RandomMovieTVShowAPI/MovieProject/Database/movies.json", options);
            }

        }
    }

}
