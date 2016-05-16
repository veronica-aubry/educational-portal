using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using System.Text.RegularExpressions;
using MeriEducation.Models;

namespace MeriEducation.Models
{
    public class VocabResponse
    {
        [JsonProperty("response")]
        public List<VocabObject> response { get; set; }
    }
    public class VocabObject
    {
        [JsonProperty("list")]
        public VocabMatch list { get; set; }

    }
    public class VocabMatch
    {
        [JsonProperty("category")]
        public string category { get; set; }
        [JsonProperty("synonyms")]
        public string synonyms { get; set; }

        public static List<VocabObject> GetMatches(string VocabWord)
        {
            var client = new RestClient("http://thesaurus.altervista.org/");
            var request = new RestRequest("thesaurus/v1?word={word}&language=en_US&key={key}&output=json", Method.GET);
            request.AddUrlSegment("word", VocabWord);
            request.AddUrlSegment("key", EnvironmentVariables.Key);
            var response = client.Execute(request);
            var wordMatches = JsonConvert.DeserializeObject<VocabResponse>(response.Content);
            return wordMatches.response;
        }

        public static Dictionary<string, List<string>> FormatMatches(string VocabWord)
        {
            var allMatches = VocabMatch.GetMatches(VocabWord);
            List<string> synonyms = new List<string>();
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            string replacer = ", ";
            Dictionary<String, List<string>> formattedMatches = new Dictionary<String, List<string>>();

            foreach (var list in allMatches)
            {

                var formattedSynonyms = rgx.Replace(list.list.synonyms, replacer);
                formattedSynonyms = formattedSynonyms.Replace("similar term,", "").Replace("related term,", "").Replace("antonym,", "");
                Console.WriteLine(formattedSynonyms);
                synonyms.Add(formattedSynonyms);
            }

            formattedMatches.Add(VocabWord, synonyms);
            Console.WriteLine(formattedMatches);
            return formattedMatches;
        }

        public static List<Dictionary<string, List<string>>> GetMatchList(VocabWordList wordList)
        {
            List<Dictionary<string, List<string>>> result = new List<Dictionary<string, List<string>>>();
            List<string> words = new List<string>() {
                wordList.Word1,
                wordList.Word2,
                wordList.Word3,
                wordList.Word4
              };
            foreach (var word in words)
            {
                var match = VocabMatch.FormatMatches(word);
                result.Add(match);
            }

            return result;
        }

   }
}
