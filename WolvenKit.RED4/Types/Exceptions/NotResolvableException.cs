using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace WolvenKit.RED4.Types.Exceptions;

public class NotResolvableException : Exception
{
    private NotResolvableException(string? paramName) : base(paramName)
    {
    }

    public static void ThrowIfNotResolvable([NotNull] CName argument, [CallerArgumentExpression("argument")] string? paramName = null)
    {
        if (argument.IsResolvable)
        {
            Throw(paramName);
        }
    }

    public static void ThrowIfNotResolvable([NotNull] NodeRef argument, [CallerArgumentExpression("argument")] string? paramName = null)
    {
        if (argument.IsResolvable)
        {
            Throw(paramName);
        }
    }

    public static void ThrowIfNotResolvable([NotNull] TweakDBID argument, [CallerArgumentExpression("argument")] string? paramName = null)
    {
        if (argument.IsResolvable)
        {
            Throw(paramName);
        }
    }

    [DoesNotReturn]
    private static void Throw(string? paramName) =>
        throw new NotResolvableException(paramName);
}