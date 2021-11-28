using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;


namespace Wox.Plugin.SteamTable
{
    public class SteamTable : IPlugin, IPluginI18n
    {
        private PluginInitContext _context;

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

        public void Init(PluginInitContext context)
        {
            _context = context;
        }

        public List<Result> Query(Query query)
        {
            var queryString = query.Search.Trim().ToLower().Replace(" ", string.Empty);
            const string PT_PATTERN = @"^p([0-9\.]+)t([0-9\.]+)";
            const string P_L_PATTERN = @"^pl([0-9\.]+)";
            const string P_V_PATTERN = @"^pv([0-9.]+)";

            if (3 == Regex.Match(queryString, PT_PATTERN).Groups.Count)
            {
                double press = Convert.ToDouble(Regex.Match(queryString, PT_PATTERN).Groups[1].Value);
                double temp = Convert.ToDouble(Regex.Match(queryString, PT_PATTERN).Groups[2].Value);

                return PT(press, temp);
            }
            else if (2 == Regex.Match(queryString, P_L_PATTERN).Groups.Count)
            {
                double press = Convert.ToDouble(Regex.Match(queryString, P_L_PATTERN).Groups[1].Value);

                return P_L(press);
            }
            else if (2 == Regex.Match(queryString, P_V_PATTERN).Groups.Count)
            {
                double press = Convert.ToDouble(Regex.Match(queryString, P_V_PATTERN).Groups[1].Value);

                return P_V(press);
            }

            return null;
        }

        private List<Result> PT(double press, double temp)
        {
            double h = 0, s = 0, v = 0, eta = 0, k = 0;
            int r = 0;
            try
            {
                IFC97Wrapper.PT2H97(press, temp, ref h, ref r);
                IFC97Wrapper.PT2S97(press, temp, ref s, ref r);
                IFC97Wrapper.PT2V97(press, temp, ref v, ref r);
                IFC97Wrapper.PT2KS97(press, temp, ref k, ref r);
                IFC97Wrapper.PT2ETA97(press, temp, ref eta, ref r);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return new List<Result>
            {
                new Result
                {
                    Title = h + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_enthalpy"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(h + string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = s + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_entropy"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(s+ string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = v + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_specific_volume"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(v+ string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = (1/v) + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_density"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject((1/v) + string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = k + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_isentropic_index"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(k + string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = eta*1000 + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_dynamic_viscosity"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(eta*1000 + string.Empty);
                        return true;
                    }
                },

            };
        }

        private List<Result> P_L(double press)
        {
            double t = 0;
            double hL = 0, sL = 0, vL = 0, etaL = 0, kL = 0;
            int r = 0;
            try
            {
                IFC97Wrapper.P2T97(press, ref t, ref r);

                IFC97Wrapper.P2HL97(press, ref hL, ref r);
                IFC97Wrapper.P2SL97(press, ref sL, ref r);
                IFC97Wrapper.P2VL97(press, ref vL, ref r);
                IFC97Wrapper.P2ETAL97(press, ref etaL, ref r);
                IFC97Wrapper.P2KSL97(press, ref kL, ref r);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

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
                    Title = hL + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_water_enthalpy"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(hL + string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = sL + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_water_entropy"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(sL+ string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = vL + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_water_specific_volume"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(vL+ string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = (1/vL) + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_water_density"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject((1/vL) + string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = kL + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_water_isentropic_index"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(kL + string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = etaL*1000 + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_results_water_dynamic_viscosity"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(etaL*1000 + string.Empty);
                        return true;
                    }
                },


            };
        }

        private List<Result> P_V(double press)
        {
            double t = 0;
            double hG = 0, sG = 0, vG = 0, etaG = 0, kG = 0;
            var r = 0;
            try
            {
                IFC97Wrapper.P2T97(press, ref t, ref r);

                IFC97Wrapper.P2HG97(press, ref hG, ref r);
                IFC97Wrapper.P2SG97(press, ref sG, ref r);
                IFC97Wrapper.P2VG97(press, ref vG, ref r);
                IFC97Wrapper.P2ETAG97(press, ref etaG, ref r);
                IFC97Wrapper.P2KSG97(press, ref kG, ref r);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

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
        }
    }
}