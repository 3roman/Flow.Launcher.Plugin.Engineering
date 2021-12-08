namespace Wox.Plugin.SteamTable.IFC97
{
    public class SuperheatedSteam : H2O
    {
        public SuperheatedSteam(double pressure, double temperature)
        {
            Pressure = pressure;
            Temperature = temperature;
            IFC97Wrapper.PT2H97(Pressure, Temperature, ref _enthalpy, ref _region);
            IFC97Wrapper.PT2S97(Pressure, Temperature, ref _entropy, ref _region);
            IFC97Wrapper.PT2V97(Pressure, Temperature, ref _specificVolume, ref _region);
            IFC97Wrapper.PT2KS97(Pressure, Temperature, ref _isentropicIndex, ref _region);
            IFC97Wrapper.PT2ETA97(Pressure, Temperature, ref _dynamiViscosity, ref _region);
        }
    }
}
