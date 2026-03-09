namespace GenericTypes.Exercise;

public class Lambda
{
    public Func<string, int> GetLength = s => s.Length;
    public Func<int> GetRandomNumberBetween1And10 = () => new Random().Next(1, 10);
}
