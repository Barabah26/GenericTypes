namespace GenericTypes.Exercise;

public static class TupleSwapExercise
{
    public static Tuple<T2, T1> SwapTupleItems<T1, T2>(Tuple<T1, T2> input) => new Tuple<T2, T1>(input.Item2, input.Item1);

}
