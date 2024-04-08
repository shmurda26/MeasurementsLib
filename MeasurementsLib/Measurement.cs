namespace MeasurementsLib
{
    public class Measurement
    {
        public int Id {  get; set; }
        public double Ppm { get; set; }

        public override string ToString () => $"({Ppm})";
        public void ValidatePpm ()
        {
            if (Ppm < 0) 
            {
                throw new ArgumentOutOfRangeException($"Ppm needs to be more than zero");

            }
        }

    }
}
