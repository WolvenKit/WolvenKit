using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Threading;
using WolvenKit.App.Helpers;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel
{
    private readonly List<int> _resolvedHashes = new();

    public int NumReplacedEntries;




    /// <summary>
    ///  Entry point for search/replace
    /// </summary>
    /// <param name="search"></param>
    /// <param name="replace"></param>
    /// <param name="isWholeWord"></param>
    /// <param name="isRegex"></param>
    /// <returns></returns>
    private int SearchAndReplaceInternal(string search, string replace, bool isWholeWord, bool isRegex)
    {
        _resolvedHashes.Clear();
        NumReplacedEntries = 0;

        if (!SearchAndReplaceInProperties(search, replace, isWholeWord, isRegex))
        {
            return NumReplacedEntries;
        }

        RecalculateProperties();
        CalculateValue();
        CalculateDescriptor();

        return NumReplacedEntries;
    }


    // Level 1 (will call itself recursively, so let's abort here if we can)
    private bool SearchAndReplaceInProperties(string search, string replace, bool isWholeWord, bool isRegex)
    {
        // this will enforce CalculateProperties to be called if it isn't
        var properties = GetProperties();

        if (_resolvedHashes.Contains(GetHashCode()))
        {
            return false;
        }

        var expansionState = IsExpanded;

        // Log changed states from children
        var wasChanged = false;

        // ReSharper disable once LocalVariableHidesMember
        var scopedLocalData = Data;
        // ReSharper disable once LocalVariableHidesMember
        var scopedResolvedData = ResolvedData;
        
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
            || PropertyType.IsAssignableTo(typeof(DataBuffer))
            || PropertyType.IsAssignableTo(typeof(IRedLegacySingleChannelCurve)))
        {
            return false;
        }

        if (SearchAndReplaceInObjectProperties(search, replace, isWholeWord, isRegex, scopedResolvedData, out var newType))
        {
            if (Data is IRedHandle handle && newType is RedBaseClass newRedType)
            {
                handle.SetValue(newRedType);
                NumReplacedEntries += 1;
                wasChanged = true;
            }
            else if (newType.GetType().IsAssignableTo(scopedLocalData.GetType()))
            {
                Data = newType;
                NumReplacedEntries += 1;
                wasChanged = true;
            }
            else
            {
                _loggerService.Debug($"Search and replace: failed to replace ${Data.GetType().Name} with ${newType.GetType().Name}");
            }
        }


        wasChanged = ReplaceInFields(search, replace, isWholeWord, isRegex) || wasChanged;

        // Now, replace in child properties
        // ReSharper disable once ForCanBeConvertedToForeach Not this time
        for (var i = 0; i < properties.Count; i++)
        {
            var t = properties[i];
            try
            {
                wasChanged = t.SearchAndReplaceInProperties(search, replace, isWholeWord, isRegex) || wasChanged;
            }
            catch (Exception e)
            {
                _loggerService.Debug($"Error when trying to set {t.Name}: {e.Message}");
            }

            Properties[i] = t;
        }

        // Any changed properties will be expanded, let's re-fold to how it used to be
        IsExpanded = expansionState;

        // Certain types have the same hash as their children
        if (Properties.Count != 1)
        {
            _resolvedHashes.Add(GetHashCode());
        }

        return wasChanged;
    }

    // Duplicate-safe search and replace
    private static string ReplaceInString(string input, string searchOrPattern, string replace, bool isWholeWord, bool isRegex)
    {
        if (isWholeWord)
        {
            if (input == searchOrPattern)
            {
                return replace;
            }

            return input;
        }
        
        var placeholder = Guid.NewGuid().ToString();
        if (isRegex)
        {
            return Regex.Replace(input, Regex.Escape(searchOrPattern), placeholder).Replace(placeholder, replace);
        }

        return input.Replace(searchOrPattern, placeholder).Replace(placeholder, replace);
    }

    private bool SearchAndReplaceInReference(string search, string replace, bool isWholeWord, bool isRegex,
        IRedRef reference, out IRedRef outReference)
    {
        // ReSharper disable once UnusedVariable Keep this for debugging
        var original = reference;
        
        outReference = reference;
        if (reference.DepotPath.GetResolvedText() is not string depotPath ||
            (!IsInArray && _resolvedHashes.Contains(reference.DepotPath.GetHashCode())))
        {
            return false;
        }

        var newValue = ReplaceInString(depotPath, search, replace, isWholeWord, isRegex);
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

        var constructor = resourceReferenceType.GetConstructor([typeof(ResourcePath)]);

        if (constructor == null)
        {
            return false;
        }

        _resolvedHashes.Add(replace.GetHashCode());
            
        outReference = (IRedRef)constructor.Invoke([(ResourcePath)newValue]);
        NumReplacedEntries += 1;
        return true;
    }

    private bool SearchAndReplaceInObjectProperties(string search, string replace,
        bool isWholeWord, bool isRegex,
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
                if (string.IsNullOrEmpty(cname.GetResolvedText()))
                {
                    return false;
                }

                var resolved = cname.GetResolvedText()!;
                replaced = ReplaceInString(resolved, search, replace, isWholeWord, isRegex);
                if (replaced == resolved)
                {
                    return false;
                }

                ret = (CName)replaced;
                NumReplacedEntries += 1;
                return true;
            case IRedArray redArray:
                wasChanged = false;
                for (var i = 0; i < redArray.Count; i++)
                {
                    var o = redArray[i];
                    switch (o)
                    {
                        case IRedBaseHandle handle when handle.GetValue() is IRedType handleValue &&
                                                        SearchAndReplaceInObjectProperties(search, replace,
                                                            isWholeWord, isRegex,
                                                            handleValue,
                                                            out var newHandleValue):
                        {
                            handle.SetValue((RedBaseClass)newHandleValue);
                            wasChanged = true;
                        }
                            break;
                        case IRedType redType:
                            if (SearchAndReplaceInObjectProperties(search, replace,
                                    isWholeWord, isRegex, redType, out var newType))
                            {
                                redArray[i] = newType;
                                wasChanged = true;
                            } 
                            break;
                        default:
                            break;
                    }
                }

                return wasChanged;
            case IRedString str when str.ToString() is string s && !string.IsNullOrEmpty(s):
                replaced = s.Replace(search, replace);
                if (replaced == str.ToString() || s.Contains(replace))
                {
                    return false;
                }

                switch (str)
                {
                    case CString:
                        ret = (CString)replaced;
                        NumReplacedEntries += 1;
                        return true;
                    case ResourcePath:
                        ret = (ResourcePath)replaced;
                        NumReplacedEntries += 1;
                        return true;
                    default:
                        _loggerService.Info($"Search&Replace not yet implemented for IRedString {original.GetType().Name}");
                        return false;
                }

            case IRedRef reference:

                if (!SearchAndReplaceInReference(search, replace, isWholeWord, isRegex, reference, out var newReference))
                {
                    return false;
                }

                ret = newReference;
                return true;
            case CKeyValuePair keyValuePair:
                var oldKey = keyValuePair.Key.GetResolvedText() ?? "";
                var newKey = ReplaceInString(oldKey, search, replace, isWholeWord, isRegex);
                if (oldKey != newKey)
                {
                    NumReplacedEntries += 1;
                    wasChanged = true;
                    DispatcherHelper.RunOnMainThread(() =>  keyValuePair.Key = newKey);
                }

                if (keyValuePair.Value is IRedRef valueRef &&
                    SearchAndReplaceInReference(search, replace, isWholeWord, isRegex, valueRef, out var newRef))
                {
                    NumReplacedEntries += 1;
                    wasChanged = true;
                    DispatcherHelper.RunOnMainThread(() => keyValuePair.Value = newRef);
                }

                return wasChanged;
            
            case IRedBaseHandle handle when handle.GetValue() is IRedType handleValue:

            {
                if (SearchAndReplaceInObjectProperties(search, replace, isWholeWord, isRegex, handleValue,
                        out var newHandleValue))
                {
                    handle.SetValue((RedBaseClass)newHandleValue);
                    return true;
                }

                return false;
            }
            case CMaterialInstance materialInstance:

                if (SearchAndReplaceInReference(search, replace, isWholeWord, isRegex, materialInstance.BaseMaterial, out var newMaterial))
                {
                   
                    DispatcherHelper.RunOnMainThread(() =>  materialInstance.BaseMaterial = (CResourceReference<IMaterial>)newMaterial);
                    wasChanged = true;
                }

                if (SearchAndReplaceInObjectProperties(search, replace, isWholeWord, isRegex, materialInstance.Values, out var newValues))
                {
                    DispatcherHelper.RunOnMainThread(() =>  materialInstance.Values = (CArray<CKeyValuePair>)newValues);
                    wasChanged = true;
                }

                return wasChanged;


            case IRedMeshComponent meshComponent:
            {
                var meshRet = false;
                if (SearchAndReplaceInObjectProperties(search, replace, isWholeWord, isRegex, meshComponent.MeshAppearance,
                        out var newAppearance) &&
                    newAppearance is CName cname)
                {
                    meshRet = true;
                    DispatcherHelper.RunOnMainThread(() =>   meshComponent.MeshAppearance = cname);
                }

                if (!SearchAndReplaceInReference(search, replace, isWholeWord, isRegex, meshComponent.Mesh, out var newMesh)
                    || newMesh is not CResourceAsyncReference<CMesh> meshRef)
                {
                    return meshRet;
                }

                meshComponent.Mesh = meshRef;
                return true;
            }
            case RedBaseClass irc:
            {
                foreach (var propName in s_replacementPropertyNames)
                {
                    var prop = RedReflection.GetPropertyByRedName(irc.GetType(), propName);
                    if (prop?.RedName is null || irc.GetProperty(prop.RedName.NotNull()) is not IRedType propValue
                                              || propValue.ToString() is null or "None" or "")
                    {
                        continue;
                    }

                    var newValue = propValue.ToString()?.Replace(search, replace);

                    // ReSharper disable UnusedVariable Keep for debugging
                    if (propValue is IRedRef { DepotPath: var depotPath } reference
                        && SearchAndReplaceInReference(search, replace, isWholeWord, isRegex, reference, out var newRef2)
                        && newRef2 is { DepotPath: var depotPath2 } rr2)
                    {
                        newValue = depotPath2.GetResolvedText() ?? "";
                        // TODO: This might require more attention
                    }
                    // ReSharper enable UnusedVariable

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

                    if (propValue is CName && null != newValue)
                    {
                        DispatcherHelper.RunOnMainThread(() =>  propInfo.SetValue(irc, (CName)newValue));
                        NumReplacedEntries += 1;
                        wasChanged = true;
                        continue;
                    }

                    if (!propInfo.GetType().IsAssignableTo(prop.GetType()))
                    {
                        if (!propInfo.GetType().Name.StartsWith("Runtime"))
                        {
                            _loggerService.Debug(
                                $"Can't replace in {propertyName} ({propInfo.GetType().Name}) can't be assigned to {prop.GetType().Name})");
                        }

                        continue;       
                    }


                    // TODO: This throws exceptions with CNames, how do we prevent that?
                    try
                    {
                        propInfo.SetValue(irc, newValue);
                        NumReplacedEntries += 1;
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
    private bool ReplaceInFields(string search, string replace, bool isWholeWord, bool isRegex)
    {
        var wasChanged = false;

        foreach (var property in ResolvedData.GetType().GetProperties())
        {
            try
            {
                // Get the name of the property
                var propertyName = property.Name;

                // Get the value of the property
                var propertyValue = property.GetValue(ResolvedData);

                if (propertyValue is not (List<CName> or CName) and IRedType redType)
                {
                    if (SearchAndReplaceInObjectProperties(search, replace, isWholeWord, isRegex, redType,
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
                            var oldValue = ary[i].GetResolvedText() ?? "";
                            newValue = ReplaceInString(oldValue, search, replace, isWholeWord, isRegex);
                            if (oldValue == newValue)
                            {
                                continue;
                            }

                            ary[i] = (CName)newValue;
                            NumReplacedEntries += 1;
                            wasChanged = true;
                        }

                        continue;
                    }
                    case CName cname when cname.GetResolvedText() is string s:

                        newValue = ReplaceInString(s, search, replace, isWholeWord, isRegex);
                        if (s != newValue)
                        {
                            property.SetValue(ResolvedData, newValue);
                            NumReplacedEntries += 1;
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