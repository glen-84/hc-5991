namespace hc_5991;

public class GqlDbError
{
    public GqlDbError(NullReferenceException e)
    {
        Message = e.Message;
    }

    public GqlDbError(ApplicationException e)
    {
        Message = e.Message;
    }

    public string Message { get; set; }
}
