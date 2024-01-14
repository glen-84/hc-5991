namespace hc_5991.Types;

[MutationType]
public static class Mutation
{
    [Error<GqlDbError>]
    [UseMutationConvention]
    public static string Test()
    {
        return "test";
    }
}
