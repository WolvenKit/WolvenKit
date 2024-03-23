using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel : ObservableObject
{
    private bool SearchAndReplaceInReference(string search, string replace, StringComparison searchMode,
        IRedRef reference, out IRedRef outReference)
    {
        outReference = reference;
        if (reference.DepotPath.GetResolvedText() is not string depotPath)
        {
            return false;
        }

        var newValue = depotPath.Replace(search, replace, searchMode);
        if (newValue == depotPath)
        {
            return false;
        }

        // Do beautiful reflection rather than defining a switch case for every single potential inheritor of CResourceSomething

        var referenceType = reference.GetType();
        if (!referenceType.IsGenericType || referenceType.GetGenericTypeDefinition() is not { } type
                                         || (type != typeof(CResourceAsyncReference<>) &&
                                             type != typeof(CResourceReference<>)))
        {
            return false;
        }

        var genericType = referenceType.GetGenericArguments()[0];
        var resourceReferenceType = typeof(CResourceReference<>).MakeGenericType(genericType);
        var constructor = resourceReferenceType?.GetConstructor([typeof(ResourcePath)]);

        if (constructor == null)
        {
            return false;
        }

        outReference = (IRedRef)constructor.Invoke([(ResourcePath)newValue]);
        return true;
    }

    private bool SearchAndReplaceInObjectProperties(string search, string replace, StringComparison searchMode,
        IRedType original, out IRedType ret)
    {
        var wasChanged = false;
        ret = original;
        switch (original)
        {
            case RedDummy:
            case CBool:
            case CUInt8:
            case CByteArray:
            case CUInt16:
            case CUInt32:
            case CUInt64:
            case CFloat:
            case CDouble:
                return false;
            case CName cname:
                if (cname.GetResolvedText() is (null or "" or "None"))
                {
                    return false;
                }

                var replaced = (cname.GetResolvedText() ?? "").Replace(search, replace, searchMode);
                if (replaced == (cname.GetResolvedText() ?? ""))
                {
                    return false;
                }

                ret = (CName)replaced;
                return true;
            case IRedRef reference:
                if (SearchAndReplaceInReference(search, replace, searchMode, reference, out var newReference))
                {
                    ret = newReference;
                }

                return true;
            case CKeyValuePair keyValuePair:
                var newKey = keyValuePair.Key.GetResolvedText()?.Replace(search, replace, searchMode);
                if (newKey is not null && newKey != keyValuePair.Key.GetResolvedText())
                {
                    keyValuePair.Key = newKey;
                    wasChanged = true;
                }

                if (keyValuePair.Value is IRedRef valueRef &&
                    SearchAndReplaceInReference(search, replace, searchMode, valueRef, out var newRef))
                {
                    wasChanged = true;
                    keyValuePair.Value = newRef;
                }

                return wasChanged;
            case RedBaseClass irc:
            {
                foreach (var propName in s_DescriptorPropNames)
                {
                    var prop = RedReflection.GetPropertyByRedName(irc.GetType(), propName);

                    if (prop?.RedName is null
                        || irc.GetProperty(prop.RedName.NotNull()) is not IRedType propValue
                        || propValue.ToString() is null or "None" or "")
                    {
                        continue;
                    }

                    var newValue = propValue.ToString()?.Replace(search, replace, searchMode);
                    if (propValue.ToString() == newValue)
                    {
                        continue;
                    }

                    // Check if the property exists and is writable. Go to public property setter from name field
                    var propertyName = prop.RedName.TrimStart('_');
                    propertyName = char.ToUpper(propertyName[0]) + propertyName[1..];

                    wasChanged = true;
                    if (irc.GetType().GetProperty(propertyName) is { CanWrite: true } propInfo)
                    {
                        // TODO: This throws exceptions with CNames, how do we prevent that?
                        try
                        {
                            propInfo.SetValue(irc, newValue);
                        }
                        catch
                        {
                            // don't set it then, I GUESS
                        }
                    }
                }

                return wasChanged;
            }
            case IRedBaseHandle handle when handle.GetValue() is IRedType handleValue:

            {
                if (SearchAndReplaceInObjectProperties(search, replace, searchMode, handleValue,
                        out var newHandleValue))
                {
                    handle.SetValue((RedBaseClass)newHandleValue);
                    return true;
                }

                return false;
            }
            case IRedArray redArray:
                wasChanged = false;
                foreach (var o in redArray)
                {
                    switch (o)
                    {
                        case IRedBaseHandle handle when handle.GetValue() is IRedType handleValue &&
                                                        SearchAndReplaceInObjectProperties(search, replace, searchMode,
                                                            handleValue,
                                                            out var newHandleValue):
                        {
                            handle.SetValue((RedBaseClass)newHandleValue);
                            return true;
                        }
                        case IRedType redType:
                            return SearchAndReplaceInObjectProperties(search, replace, searchMode, redType,
                                out var newType);
                        default:
                            return false;
                    }
                }

                return wasChanged;
            default:
            {
                if (PropertyType.IsAssignableTo(typeof(IRedEnum)))
                {
                    return false;
                }

                _loggerService.Info(
                    $"Search&Replace not yet implemented for {ResolvedData.GetType().Name}");
                return false;
            }
        }
    }

    private bool SearchAndReplaceInProperties(string search, string replace, bool ignoreCase = false) =>
        SearchAndReplaceInProperties(search, replace,
            ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);

    private bool SearchAndReplaceInProperties(string search, string replace, StringComparison searchMode)
    {
        var expansionState = IsExpanded;

        // Log changed states from children
        var wasChanged = false;


        if (SearchAndReplaceInObjectProperties(search, replace, searchMode, ResolvedData, out var newType))
        {
            wasChanged = true;
            Data = newType;
        }

        wasChanged = ReplaceInFields(search, replace, searchMode) || wasChanged;

        RecalculateProperties();

        // Now, replace in child properties
        // ReSharper disable once LoopCanBeConvertedToQuery Not this time
        foreach (var t in Properties)
        {
            wasChanged = t.SearchAndReplaceInProperties(search, replace, searchMode) || wasChanged;
        }

        CalculateValue();
        CalculateDescriptor();

        // Any changed properties will be expanded, let's re-fold to how it used to be
        IsExpanded = expansionState;

        return wasChanged;
    }

    private bool ReplaceInArrayElement(string search, string replace, StringComparison searchMode, object o)
    {
        switch (o)
        {
            case IRedBaseHandle handle
                when SearchAndReplaceInObjectProperties(search, replace, searchMode, handle, out var newHandle):
            {
                var pointee = RedTypeManager.CreateRedType(handle.InnerType);
                handle.SetValue((RedBaseClass)newHandle);
                return true;
            }
            case IRedType redType:
                return SearchAndReplaceInObjectProperties(search, replace, searchMode, redType, out var newType);
            default:
                return false;
        }
    }


    /// <summary>
    /// Without this, some items in CKeyValueArrays are being left out. I guess I'm leaving this in!
    /// </summary>
    /// <returns>true if a field value was changed</returns>
    private bool ReplaceInFields(string search, string replace, StringComparison searchMode)
    {
        var wasChanged = false;
        var fields = ResolvedData.GetType()
            .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var field in fields)
        {
            if (field.GetValue(ResolvedData) is not (List<CName> or CName))
            {
                continue;
            }

            string? newValue;
            switch (field.GetValue(ResolvedData))
            {
                case List<CName> ary:
                {
                    for (var i = 0; i < ary.Count; i++)
                    {
                        newValue = ary[i].GetResolvedText()?.Replace(search, replace, searchMode);
                        if (null == newValue || ary[i].GetResolvedText() == newValue)
                        {
                            continue;
                        }

                        ary[i] = (CName)newValue;
                        wasChanged = true;
                    }

                    continue;
                }
                case CName cname when cname.GetResolvedText() is string s:

                    newValue = s.Replace(search, replace, searchMode);
                    if (!Equals(s, newValue))
                    {
                        field.SetValue(ResolvedData, s.Replace(search, replace, searchMode));
                        wasChanged = true;
                    }

                    continue;
                default:
                    continue;
            }
        }

        return wasChanged;
    }
}