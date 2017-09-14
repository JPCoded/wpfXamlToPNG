namespace wpfXamlToPNG
{
    public interface IDataPoints
    {
        void ParsePoints(string points);
        void AddPoints(string points);
        (double, double) GetPoints();
        string GetCommand();
    }
}