namespace Fractals.Extensions
{
    public static class JuliaSettings
    {
        public static double CReal { get; set; } = 0.0051231;
        public static double CImagine { get; set; } = -0.9914112;

    }

    public static class NewtonSettings
    {
        public static double XMultiplier { get; set; } = 0.002;
        public static double YMultiplier { get; set; } = 0.002;

    }
}
