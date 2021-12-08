using System.Collections.Generic;
using System.Windows;
using Wox.Plugin.SteamTable.IFC97;


namespace Wox.Plugin.SteamTable
{
    public class SteamTable : IPlugin
    {
        public void Init(PluginInitContext context)
        {
        }

        public List<Result> Query(Query query)
        {
            var raw = query.Search.Trim().ToLower();
            var results = new List<Result>();
            if (raw.StartsWith(@"pt") &&
                !string.IsNullOrWhiteSpace(raw.Replace(@"pt", string.Empty)))
            {
                var param = raw.Replace(@"pt", string.Empty).Trim().Split(' ');
                if (2 == param.Length)
                {
                    double.TryParse(param[0], out double press);
                    double.TryParse(param[1], out double temp);
                    return MakeResult(new SuperheatedSteam(press, temp));
                }
            }
            else if (raw.StartsWith(@"pl") &&
                !string.IsNullOrWhiteSpace(raw.Replace(@"pl", string.Empty)))
            {
                var param = raw.Replace(@"pl", string.Empty).Trim();
                double.TryParse(param, out double press);
                return MakeResult(new SaturatedWater(press));
            }
            else if (raw.StartsWith(@"pg") &&
               !string.IsNullOrWhiteSpace(raw.Replace(@"pg", string.Empty)))
            {
                var param = raw.Replace(@"pg", string.Empty).Trim();
                double.TryParse(param, out double press);
                return MakeResult(new SaturatedSteam(press));
            }

            return results;
        }

        public List<Result> MakeResult(H2O h2o)
        {
            var results = new List<Result>
            {
                new Result
                {
                    Title = h2o.Pressure + string.Empty,
                    SubTitle = "压力[MPaA]",
                },
                new Result
                {
                    Title = h2o.Temperature + string.Empty,
                    SubTitle = "温度[℃]",
                },
                new Result
                {
                    Title = h2o.Enthalpy + string.Empty,
                    SubTitle = "比焓[kJ/kg]",
                },
                new Result
                {
                    Title = h2o.Entropy + string.Empty,
                    SubTitle = "比熵[kJ/kg.℃]",
                },
                new Result
                {
                    Title = h2o.SpecificVolume + string.Empty,
                    SubTitle = "比体积[m³/kg]",
                },
                new Result
                {
                    Title = h2o.DynamiViscosity + string.Empty,
                    SubTitle = "动力粘度[cp]",
                },
                new Result
                {
                    Title = h2o.IsentropicIndex + string.Empty,
                    SubTitle = "等熵指数",
                }
            };

            results.ForEach(x => x.Action =
                _ =>
                {
                    Clipboard.SetDataObject(x.Title);
                    return true;
                }
            );

            return results;
        }

        #region 国际化
        //public string GetLanguagesFolder()
        //{
        //    return null;
        //}

        //public string GetTranslatedPluginTitle()
        //{
        //    return _context.API.GetTranslation("wox_plugin_title");
        //}

        //public string GetTranslatedPluginDescription()
        //{
        //    return _context.API.GetTranslation("wox_plugin_description");
        //}
        #endregion
    }
}