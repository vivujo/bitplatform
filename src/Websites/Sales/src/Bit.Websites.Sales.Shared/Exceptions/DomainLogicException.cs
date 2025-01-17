﻿namespace Bit.Websites.Sales.Shared.Exceptions;

public class DomainLogicException : KnownException
{
    public DomainLogicException(string message)
        : base(message)
    {
    }

    public DomainLogicException(string message, Exception? innerException)
        : base(message, innerException)
    {
    }
}
