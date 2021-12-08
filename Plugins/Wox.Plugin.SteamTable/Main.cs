using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;
using Wox.Plugin.SteamTable.IFC97;


namespace Wox.Plugin.SteamTable
{
    public class Main : IPlugin, IPluginI18n
    {
        private PluginInitContext _context;

        public void Init(PluginInitContext context)
        {
            _context = context;
        }

        public List<Result> Query(Query query)
        {
            //if (query.ActionKeyword == "st")
            //{
            //    var search = query.Search.Trim().ToLower();
            //    return DisPatcher(search);
            //}

            return null;
        }

        public static H2O DisPatcher(string search)
        {
            // 模式匹配
            const string PT_PATTERN = @"([0-9\.]+)\s+([0-9\.]+)";
            const string P_L_PATTERN = @"^pl([0-9\.]+)";
            const string P_V_PATTERN = @"^pv([0-9.]+)";

            // 分组结果的排头元素是原始字符串
            if (3 == Regex.Matches(search, PT_PATTERN).Count)
            {
                double.TryParse(Regex.Match(search, PT_PATTERN).Groups[1].Value, out double press);
                double.TryParse(Regex.Match(search, PT_PATTERN).Groups[2].Value, out double temp);

                return new SuperheatedSteam(press, temp);
            }
            else if (2 == Regex.Matches(search, P_L_PATTERN).Count)
            {
                double.TryParse(Regex.Match(search, P_L_PATTERN).Groups[1].Value, out double press);

                return new SaturatedWater(press);
            }
            else if (2 == Regex.Matches(search, P_V_PATTERN).Count)
            {
                double.TryParse(Regex.Match(search, P_V_PATTERN).Groups[1].Value, out double press);

                return new SaturatedSteam(press);
            }

            return null;
        }

        #region 国际化
        public string GetLanguagesFolder()
        {
            return null;
        }

        public string GetTranslatedPluginTitle()
        {
            return _context.API.GetTranslation("wox_plugin_title");
        }

        public string GetTranslatedPluginDescription()
        {
            return _context.API.GetTranslation("wox_plugin_description");
        }
        #endregion
    }
}


/*

  return new List<Result>
            {
                new Result
                {
                    Title = t + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_saturated_temperature"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(t + string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = hG + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_vapor_enthalpy"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(hG + string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = sG + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_vapor_entropy"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(sG+ string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = vG + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_vapor_specific_volume"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(vG+ string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = (1/vG) + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_vapor_density"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject((1/vG) + string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = kG + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_vapor_isentropic_index"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(kG + string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = etaG*1000 + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_vapor_dynamic_viscosity"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(etaG*1000 + string.Empty);
                        return true;
                    }
                },
            };
 * 
 * 
 */
