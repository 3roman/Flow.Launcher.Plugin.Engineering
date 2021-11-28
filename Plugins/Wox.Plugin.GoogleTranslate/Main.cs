using GoogleTranslateFreeApi;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


namespace Wox.Plugin.GoogleTranslate
{
    public class Main : IPlugin
    {
        public List<Result> Query(Query query)
        {
            var result = new Result
            {
                Title = "Hello World from CSharp",
                SubTitle = $"Query: {query.Search}",
                IcoPath = Path.Combine("Images", "app.png")
            };

            return new List<Result> { result };
        }

        public void Init(PluginInitContext context)
        {

        }

        public string GoogleTranslate(string input)
        {
            var _translator = new GoogleTranslator();
            TranslationResult result;
            if (IsChinese(input))
            {
                result = _translator.TranslateAsync(
                    input,
                    Language.ChineseSimplified,
                    Language.English).GetAwaiter().GetResult();
            }
            else
            {
                result = _translator.TranslateAsync(
                    input,
                    Language.English,
                    Language.ChineseSimplified).GetAwaiter().GetResult();
            }

            return result.MergedTranslation;
        }

        public bool IsChinese(string input)
        {
            const string pattern = @"[\u4e00-\u9fff]";
            return Regex.IsMatch(input, pattern);
        }

        //public string MakeURL(string input)
        //{
        //    var targetLanguage = IsChinese(input) ? "zh-CN" : "en";
        //    return $"https://translate.google.com/?sl=auto&tl={targetLanguage}&text={input}&op=translate";
        //}

        //public string Translate(string input)
        //{
        //    var url = MakeURL(input);
        //    var tResponse = new HttpClient().GetAsync(url);
        //    tResponse.Wait();
        //    var tContent = tResponse.Result.Content.ReadAsStringAsync();
        //    tContent.Wait();
        //    var result = tContent.Result;
        //    var jResult = JsonConvert.DeserializeObject<JArray>(result);

        //    Debug.WriteLine(jResult);

        //    return jResult.First.First.First.Value<string>();
        //}
    }
}