namespace Wox.Plugin.SteamTable.IFC97
{
    public class SaturatedSteam : H2O
    {
        public SaturatedSteam(double saturatedPressure)
        {
            Pressure = saturatedPressure;
            IFC97Wrapper.P2T97(Pressure, ref _temperature, ref _region);
            IFC97Wrapper.P2HG97(Pressure, ref _enthalpy, ref _region);
            IFC97Wrapper.P2SG97(Pressure, ref _entropy, ref _region);
            IFC97Wrapper.P2VG97(Pressure, ref _specificVolume, ref _region);
            IFC97Wrapper.P2KSG97(Pressure, ref _isentropicIndex, ref _region);
            IFC97Wrapper.P2ETAG97(Pressure, ref _dynamiViscosity, ref _region);
        }
    }
}
