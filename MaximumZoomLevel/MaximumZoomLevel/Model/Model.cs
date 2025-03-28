 namespace MaximumZoomLevel
{
    public class Model
    { 
        public double Score { get; set; }
        public double Over { get; set; }

        public Model(double score, double over)
        { 
            Over = over;
            Score = score;
        } 
    } 
}
