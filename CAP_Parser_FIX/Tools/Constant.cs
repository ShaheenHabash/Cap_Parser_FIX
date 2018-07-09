public enum Format
{
    Char,
    String,
    Bool,
    Int,
    Qty,

    // (maximum value 999,999.999)
    Price,
    Float,
    SeqNum,

    // YYYYMMDD-HH:MM:SS
    UTCTimestamp,

    // YYYYMMDD
    LocalMktDate
}

public enum Persence
{
    Required,
    Optional,
    Conditional
}


