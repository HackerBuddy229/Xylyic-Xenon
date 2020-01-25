using System;
using System.Collections.Generic;
using System.IO;

namespace Xylyic_Xenon.Services {
    public class WordService{

        public List<string> _Adjectives {get; set;}
        public List<string> _Nounes {get; set;}

        public WordService(){
            _Adjectives = PopulateAdjectives();
            _Nounes = PopulateNounes();
        }

        private List<string> PopulateNounes()
        {
            var Nouns = new List<string>();

            using (var streamReader = new StreamReader("Nouns.txt")){
                while(true){
                    var noun = streamReader.ReadLine();
                    if (noun != null){
                        Nouns.Add(noun);
                    } else {
                        break;
                    }
                }
            }
            return Nouns;
        }

        private List<string> PopulateAdjectives()
        {
            var Adjectives = new List<string>();

            using (var streamReader = new StreamReader("Adjectives.txt")){
                while(true){
                    var adjective = streamReader.ReadLine();
                    if (adjective != null){
                        Adjectives.Add(adjective);
                    } else {
                        break;
                    }
                }
            }
            return Adjectives;
        }
    }
}