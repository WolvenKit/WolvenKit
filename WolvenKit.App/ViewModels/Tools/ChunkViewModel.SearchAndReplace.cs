using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData;
using Microsoft.EntityFrameworkCore.Metadata;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel : ObservableObject
{
    private readonly List<int> resolvedHashes = new();

    public static int NumReplacedEntries = 0;

    private static void ResetReplacementCounter() => NumReplacedEntries = 0;

    private static void IncrementReplacementCounter() => NumReplacedEntries += 1;

    /// <summary>
    ///  Entry point for search/replace
    /// </summary>
    /// <param name="search"></param>
    /// <param name="replace"></param>
    /// <param name="ignoreCase"></param>
    /// <returns></returns>
    private bool SearchAndReplaceInProperties(string search, string replace, bool ignoreCase = false)
    {
        resolvedHashes.Clear();
        ResetReplacementCounter();
        
        var result = SearchAndReplaceInProperties(search, replace,
            ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);

        if (result)
        {
            RecalculateProperties();
            CalculateValue();
            CalculateDescriptor();
        }

        return result;
    }


    // Level 1 (will call itself recursively, so let's abort here if we can)
    private bool SearchAndReplaceInProperties(string search, string replace, StringComparison searchMode)
    {
        if (!IsInArray && resolvedHashes.Contains(ResolvedData.GetHashCode()))
        {
            return false;
        }

        var expansionState = IsExpanded;

        // Log changed states from children
        var wasChanged = false;

        var _data = Data;
        var _resolvedData = ResolvedData;
        
        switch (ResolvedData)
        {
            case RedDummy:
            case IRedInteger:
            case CByteArray:
            case IRedBufferWrapper:
            case FixedPoint:
                return false;
            case IRedPrimitive when !IsArray:
                if (ResolvedData is not IRedPrimitive<string>)
                {
                    return false;
                }

                break;
            default:
                break;
        }

        if (PropertyType.IsAssignableTo(typeof(IRedEnum))
            || PropertyType.IsAssignableTo(typeof(IRedInteger))
            || PropertyType.IsAssignableTo(typeof(IRedBitField))
            || PropertyType.IsAssignableTo(typeof(IRedCurvePoint))
            || PropertyType.IsAssignableTo(typeof(IRedMultiChannelCurve))
            || PropertyType.IsAssignableTo(typeof(IRedLegacySingleChannelCurve)))
        {
            return false;
        }

        if (SearchAndReplaceInObjectProperties(search, replace, searchMode, _resolvedData, out var newType))
        {
            if (Data is IRedHandle handle && newType is RedBaseClass newRedType)
            {
                handle.SetValue(newRedType);
                IncrementReplacementCounter();
                wasChanged = true;
            }
            else if (newType.GetType().IsAssignableTo(_data.GetType()))
            {
                Data = newType;
                IncrementReplacementCounter();
                wasChanged = true;
            }
            else
            {
                _loggerService.Debug($"failed to replace ${Data.GetType().Name} with ${newType.GetType().Name}");
            }
        }


        wasChanged = ReplaceInFields(search, replace, searchMode) || wasChanged;

        // RecalculateProperties();

        // Now, replace in child properties
        // ReSharper disable once LoopCanBeConvertedToQuery Not this time
        foreach (var t in Properties)
        {
            try
            {
                wasChanged = t.SearchAndReplaceInProperties(search, replace, searchMode) || wasChanged;
            }
            catch (Exception e)
            {
                _loggerService.Debug($"Error when trying to set {t.Name}: {e.Message}");
            }
        }

        // CalculateValue();
        // CalculateDescriptor();

        // Any changed properties will be expanded, let's re-fold to how it used to be
        IsExpanded = expansionState;

        // Certain types have the same hash as their children
        if (Properties.Count != 1)
        {
            resolvedHashes.Add(ResolvedData.GetHashCode());
        }

        return wasChanged;
    }
    
    private bool SearchAndReplaceInReference(string search, string replace, StringComparison searchMode,
        IRedRef reference, out IRedRef outReference)
    {
        var original = reference;
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
        var resourceReferenceType = type.MakeGenericType(genericType);
        
        var constructor = resourceReferenceType?.GetConstructor([typeof(ResourcePath)]);

        if (constructor == null)
        {
            return false;
        }

        outReference = (IRedRef)constructor.Invoke([(ResourcePath)newValue]);
        IncrementReplacementCounter();
        return true;
    }

    private bool SearchAndReplaceInObjectProperties(string search, string replace, StringComparison searchMode,
        IRedType original, out IRedType ret)
    {
        var wasChanged = false;
        ret = original;
        string? replaced;
        switch (original)
        {
            case RedDummy:
            case IRedInteger:
            case CByteArray:
            case IRedEnum:
            case IRedBufferWrapper:
            case IRedBitField:
            case meshMeshMaterialBuffer: 
                return false;
            case CName cname:
                if (cname.GetResolvedText() is (null or "" or "None"))
                {
                    return false;
                }

                replaced = (cname.GetResolvedText() ?? "").Replace(search, replace, searchMode);
                if (replaced == (cname.GetResolvedText() ?? ""))
                {
                    return false;
                }

                ret = (CName)replaced;
                IncrementReplacementCounter();
                return true;
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
                            wasChanged = true;
                        }
                            break;
                        case IRedType redType:
                            if (SearchAndReplaceInObjectProperties(search, replace, searchMode, redType, out var newType))
                            {
                                wasChanged = true;
                            } 
                            break;
                        default:
                            break;
                    }
                }

                return wasChanged;
            case IRedString str:
                replaced = (str.ToString() ?? "").Replace(search, replace, searchMode);
                if (replaced == str.ToString())
                {
                    return false;
                }

                switch (str)
                {
                    case CString:
                        ret = (CString)replaced;
                        IncrementReplacementCounter();
                        return true;
                    case ResourcePath:
                        ret = (ResourcePath)replaced;
                        IncrementReplacementCounter();
                        return true;
                    default:
                        _loggerService.Info($"Search&Replace not yet implemented for IRedString {original.GetType().Name}");
                        return false;
                }

            case IRedRef reference:
                
                if (!SearchAndReplaceInReference(search, replace, searchMode, reference, out var newReference))
                {
                    return false;
                }

                ret = newReference;
                return true;
            case CKeyValuePair keyValuePair:
                var newKey = keyValuePair.Key.GetResolvedText()?.Replace(search, replace, searchMode);
                if (newKey is not null && newKey != keyValuePair.Key.GetResolvedText())
                {
                    IncrementReplacementCounter();
                    wasChanged = true;
                    keyValuePair.Key = newKey;
                }

                if (keyValuePair.Value is IRedRef valueRef &&
                    SearchAndReplaceInReference(search, replace, searchMode, valueRef, out var newRef))
                {
                    IncrementReplacementCounter();
                    wasChanged = true;
                    keyValuePair.Value = newRef;
                }

                return wasChanged;
            
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
            case CMaterialInstance materialInstance:

                if (SearchAndReplaceInReference(search, replace, searchMode, materialInstance.BaseMaterial, out var newMaterial))
                {
                    materialInstance.BaseMaterial = (CResourceReference<IMaterial>)newMaterial;
                    wasChanged = true;
                }

                if (SearchAndReplaceInObjectProperties(search, replace, searchMode, materialInstance.Values, out var newValues))
                {
                    materialInstance.Values = (CArray<CKeyValuePair>)newValues;
                    wasChanged = true;
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

                    if (irc.GetType().GetProperty(propertyName) is not { CanWrite: true } propInfo)
                    {
                        continue;
                    }

                    if (!propInfo.GetType().IsAssignableTo(prop.GetType()))
                    {
                        if (!propInfo.GetType().Name.StartsWith("Runtime"))
                        {
                            _loggerService.Debug(
                                $"Can't replace in {propertyName} ({propInfo.GetType().Name}) can't be assigned to {prop.GetType().Name})");
                        }

                        return false;
                    }

                    // TODO: This throws exceptions with CNames, how do we prevent that?
                    try
                    {
                        propInfo.SetValue(irc, newValue);
                        IncrementReplacementCounter();
                        wasChanged = true;
                    }
                    catch
                    {
                        // don't set it then, I GUESS
                    }
                }

                return wasChanged;
            }
            default:
            {
                if (original is IRedPrimitive primitive &&
                    !(primitive.GetType().IsGenericType &&
                      primitive.GetType().GetGenericTypeDefinition() == typeof(IRedPrimitive<string>)))
                {
                    return false;
                }

                _loggerService.Info($"Search&Replace not yet implemented for {original.GetType().Name}");
                
                return false;
            }
        }
    }
    

    /// <summary>
    /// Without this, some items in CKeyValueArrays are being left out. I guess I'm leaving this in!
    /// </summary>
    /// <returns>true if a field value was changed</returns>
    private bool ReplaceInFields(string search, string replace, StringComparison searchMode)
    {
        var wasChanged = false;

        foreach (var property in ResolvedData.GetType().GetProperties())
        {
            try
            {
                // Get the name of the property
                string propertyName = property.Name;

                // Get the value of the property
                object? propertyValue = property.GetValue(ResolvedData);

                if (propertyValue is not (List<CName> or CName) && propertyValue is IRedType redType)
                {
                    if (SearchAndReplaceInObjectProperties(search, replace, searchMode, redType,
                            out var newPropertyValue))
                    {
                        wasChanged = true;
                        property.SetValue(ResolvedData, newPropertyValue);
                    }

                    continue;
                }

                string? newValue;
                switch (propertyValue)
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
                            IncrementReplacementCounter();
                            wasChanged = true;
                        }

                        continue;
                    }
                    case CName cname when cname.GetResolvedText() is string s:

                        newValue = s.Replace(search, replace, searchMode);
                        if (!Equals(s, newValue))
                        {
                            property.SetValue(ResolvedData, s.Replace(search, replace, searchMode));
                            IncrementReplacementCounter();
                            wasChanged = true;
                        }

                        continue;
                    default:
                        continue;
                }
            }
            catch // (Exception ex)
            {
                // If we can't read the property, we don't wanna replace in it.
                // _loggerService.Debug("Ran into exception for property: " + property.Name + " " + ex.Message);
            }
        }

        return wasChanged;
    }
}