namespace Wox.Plugin.SteamTable.IFC97
{
    public class SaturatedSteam : H2O
    {
        public SaturatedSteam(double param, bool isPressure = true)
        {
            if (isPressure)
            {
                Pressure = param;
                IFC97Wrapper.P2T97(Pressure, ref _temperature, ref _region);
                IFC97Wrapper.P2HG97(Pressure, ref _enthalpy, ref _region);
                IFC97Wrapper.P2SG97(Pressure, ref _entropy, ref _region);
                IFC97Wrapper.P2VG97(Pressure, ref _specificVolume, ref _region);
                IFC97Wrapper.P2KSG97(Pressure, ref _isentropicIndex, ref _region);
                IFC97Wrapper.P2ETAG97(Pressure, ref _dynamiViscosity, ref _region);
            }
            else
            {
                Temperature = param;
                IFC97Wrapper.T2P97(Temperature, ref _pressure, ref _region);
                IFC97Wrapper.T2HG97(Temperature, ref _enthalpy, ref _region);
                IFC97Wrapper.T2SG97(Temperature, ref _entropy, ref _region);
                IFC97Wrapper.T2VG97(Temperature, ref _specificVolume, ref _region);
                IFC97Wrapper.T2KSG97(Temperature, ref _isentropicIndex, ref _region);
                IFC97Wrapper.T2ETAG97(Temperature, ref _dynamiViscosity, ref _region);
            }
        }
    }
}
