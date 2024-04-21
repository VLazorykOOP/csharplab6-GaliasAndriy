namespace Lab6CSharp {
    public interface IProduct : IComparable
    {
        string Name { get; }
        void DisplayInfo();
        bool IsType(string type);
    }
}