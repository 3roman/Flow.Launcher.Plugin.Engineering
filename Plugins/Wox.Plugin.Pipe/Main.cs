using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Wox.Plugin.Pipe
{
    public class Pipe : IPlugin
    {
        private string _jsonFile;

        public void Init(PluginInitContext context)
        {
            _jsonFile = Path.Combine(context.CurrentPluginMetadata.PluginDirectory, "data.json");
        }

        public List<Result> Query(Query query)
        {
            if (3 != query.Terms.Length)
            {
                return null;
            }
            var results = new List<Result>();
            int.TryParse(query.FirstSearch, out int dn);
            var sch = query.SecondSearch.ToUpper().Trim();
            var data = ReadJsonFile<List<PipeParam>>(_jsonFile);
            if (data != null)
            {
                try
                {
                    var pipe = data.Where(x => dn == x.DN).FirstOrDefault();
                    var thk = pipe.SCHS.Where(x => x.SCH == sch).FirstOrDefault().Thk;
                    results.Add(
                        new Result
                        {
                            Title = $"{pipe.OD}x{thk}",
                            Action = _ =>
                            {
                                Clipboard.SetDataObject($"{pipe.OD}x{thk}");
                                return true;
                            }
                        });
                }
                catch (Exception)
                {
                    return null;
                }
            }

            return results;
        }

        private T ReadJsonFile<T>(string fileName)
        {
            var content = File.ReadAllText(fileName);

            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
