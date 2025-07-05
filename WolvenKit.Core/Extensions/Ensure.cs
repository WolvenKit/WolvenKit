using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Core.Extensions;

public sealed class ArgumentNullOrEmptyException : ArgumentNullException
{
    public ArgumentNullOrEmptyException(string? paramName, string? message) : base(paramName, message)
    {

    }

    public static void ThrowIfNullOrEmpty(object? argument)
        => ThrowIfNull(argument: argument);
    public static void ThrowIfNullOrEmpty(object? argument, string? paramName)
        => ThrowIfNull(argument: argument, paramName: paramName);
}

public static class Ensure
{
    [return: NotNull]
    public static T Null<T>(
        this T obj,
        Action? action = default
        )
    {
        action?.Invoke();
        return obj ?? throw new Exception();
    }

    /// <summary>
    /// Ensures an object is not null
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="message"></param>
    /// <param name="parameterName"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    [return: NotNull]
    public static T NotNull<T>(
        [NotNull] this T? obj,
        string? message = default,
        [CallerArgumentExpression("obj")] string? parameterName = default)
        where T : class =>
        obj ?? throw new ArgumentNullException(parameterName, message);

    [return: NotNull]
    public static T NotNull<T>(
        [NotNull] this T? obj,
        Action action,
        string? message = default,
        [CallerArgumentExpression("obj")] string? parameterName = default
        )
        where T : class
    {
        if (obj != null)
        {
            return obj;
        }

        action();
        throw new ArgumentNullException(parameterName, message);
    }

    /// <summary>
    /// Ensures an string is not null or empty
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="message"></param>
    /// <param name="parameterName"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullOrEmptyException"></exception>
    public static string NotNullOrEmpty(
        [NotNull] this string? obj,
        string? message = default,
        [CallerArgumentExpression("obj")] string? parameterName = default)
        => string.IsNullOrEmpty(obj) ? throw new ArgumentNullOrEmptyException(parameterName, message) : obj;

    public static bool IsNotNullOrEmpty(string str = "", Action? action = default)
    {
        switch (string.IsNullOrEmpty(str))
        {
            case true:
                action?.Invoke();
                return true;
            default:
                return false;
        }
    }

    public static bool IsNotNull<T>(T? obj, Action? action = default)
    {
        switch (obj is null)
        {
            case false:
                return true;
            default:
                action?.Invoke();
                return false;
        }
    }

}
