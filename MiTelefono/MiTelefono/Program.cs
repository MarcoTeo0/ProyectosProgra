namespace MiTelefono
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone RedmiK40Gaming = new SmartPhone();
            RedmiK40Gaming.networkTech = LTE;
            RedmiK40Gaming.Launch = 2021;
            RedmiK40Gaming.DayLaunch = 27;
            RedmiK40Gaming.DimensionsAlto = 161.9;
            RedmiK40Gaming.DimensionsAncho = 76.9;
            RedmiK40Gaming.Weight = 205;
            RedmiK40Gaming.Build = GlassFront;
            RedmiK40Gaming.SIM = true;
            RedmiK40Gaming.Type = OLED;
            RedmiK40Gaming.Brillo = 500;
            RedmiK40Gaming.Size = 6.67;
            RedmiK40Gaming.ResolutionAncho = 1080;
            RedmiK40Gaming.ResolutionAlto = 2400;
            RedmiK40Gaming.Protection = true;
            RedmiK40Gaming.NameProtection = CorllingGorillaGlass5;
        }
    }
}