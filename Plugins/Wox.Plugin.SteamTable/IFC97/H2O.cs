namespace Wox.Plugin.SteamTable.IFC97
{
    public abstract class H2O
    {
        // MPag
        protected double _pressure;

        public double Pressure
        {
            get { return _pressure; }
            set { _pressure = value; }
        }

        // ℃
        protected double _temperature;

        public double Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        // kJ/kg
        protected double _enthalpy;

        public double Enthalpy
        {
            get { return _enthalpy; }
            set { _enthalpy = value; }
        }

        // kJ/(kg.℃)
        protected double _entropy;

        public double Entropy
        {
            get { return _entropy; }
            set { _entropy = value; }
        }

        // m³/kg
        protected double _specificVolume;

        public double SpecificVolume
        {
            get { return _specificVolume; }
            set { _specificVolume = value; }
        }

        protected double _isentropicIndex;

        public double IsentropicIndex
        {
            get { return _isentropicIndex; }
            set { _isentropicIndex = value; }
        }

        // cp
        protected double _dynamiViscosity;

        public double DynamiViscosity
        {
            get { return _dynamiViscosity; }
            set { _dynamiViscosity = value; }
        }

        protected int _region;

        public int Region
        {
            get { return _region; }
            set { _region = value; }
        }
    }
}
