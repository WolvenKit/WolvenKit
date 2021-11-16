using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using WolvenKit.Interfaces.Core;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.Common.Conversion
{
    public static class Red4TextConverter
    {
        /// <summary>
        /// Parse
        /// </summary>
        /// <param name="cVariable"></param>
        /// <param name="value">either a JArray, JObject or primitive value</param>
        /// <exception cref="InvalidParsingException"></exception>
        public static void SetFromJObject(this IRedType cVariable, object value)
        {
            // switch over the jobject
            switch (value)
            {
                // enums and arrays are JArrays and can be directly deserialized
                case JArray jArray:
                    switch (cVariable)
                    {
                        // enums are serialized as list of strings
                        case IRedEnum:
                            var enumobj = jArray.ToObject<List<string>>();
                            if (enumobj == null)
                            {
                                throw new InvalidParsingException("not a CVariable");
                            }
                            //cVariable.SetValue(enumobj);
                            //break;
                            throw new NotImplementedException();
                        // arrays
                        case IRedMultiChannelCurve curve:
                        {
                            var curvePoints = jArray.ToObject<List<object>>();
                            if (curvePoints == null)
                            {
                                throw new InvalidParsingException("not a CVariable");
                            }
                            throw new NotImplementedException();
                            //for (var i = 0; i < curvePoints.Count; i++)
                            //{
                            //    var jitem = curvePoints[i];

                            //    var element = curve.GetElementInstance(i.ToString());
                            //    // parse the elements according to the array type
                            //    element.SetFromJObject(jitem);
                            //    curve.AddVariable(element);
                            //}
                            //break;
                        }
                        case IRedArray redArray:
                        {
                            throw new NotImplementedException();
                            //if (redArray.IsByteArray())
                            //{
                            //    var bytes = jArray.ToObject<byte[]>();
                            //    redArray.SetValue(bytes);
                            //}
                            //else
                            //{
                            //    var listOfObjects = jArray.ToObject<List<object>>();
                            //    if (listOfObjects == null)
                            //    {
                            //        throw new InvalidParsingException("not a CVariable");
                            //    }
                            //    for (var i = 0; i < listOfObjects.Count; i++)
                            //    {
                            //        var jitem = listOfObjects[i];

                            //        var element = redArray.GetElementInstance(i.ToString());
                            //        // parse the elements according to the array type
                            //        element.SetFromJObject(jitem);
                            //        redArray.AddVariable(element);
                            //    }
                            //}

                            //break;
                        }
                        default:
                            throw new InvalidParsingException("not a CVariable");
                    }
                //break;
                // complex objects are JObjects and can be deserialized as CVariableDto (recursive)
                case JObject jObject:
                    cVariable.SetFromDictionary(jObject.ToObject<Dictionary<string, object>>());
                    break;
                // does that ever happen?
                case JToken:
                    throw new InvalidParsingException("file format not supported");
                // primitive types can be set directly
                default:
                    //switch (value)
                    //{
                    //    // all numeric values
                    //    case long:
                    //    case double:
                    //    case BigInteger:
                    //        cVariable.SetValue(value.ToString()); // cast to string to do the parsing in the classes :/
                    //        break;
                    //    // other primitive types can be set directly
                    //    case bool b:
                    //        cVariable.SetValue(b);
                    //        break;
                    //    case string s:
                    //        cVariable.SetValue(s);
                    //        break;
                    //    default:
                    //        throw new InvalidParsingException("file format not supported");
                    //}
                    //break;
                    throw new NotImplementedException();
            }
        }

        public static void SetFromDictionary(this IRedType cvar, Dictionary<string, object> dictionary)
        {
            if (cvar is CVariant var)
            {
                var type = dictionary["Type"] as string;
                var name = "Variant";
                if (dictionary.ContainsKey("Name"))
                {
                    name = dictionary["Name"] as string;
                }

                throw new NotImplementedException();

                //var jvalue = dictionary["Variant"];
                //var variant = CR2WTypeManager.Create(type, name, cvar.Cr2wFile as IRed4EngineFile, cvar as CVariable);
                //variant.IsSerialized = true;
                //variant.SetFromJObject(jvalue);
                //var.SetVariant(variant);

                //return;
            }

            if (cvar is IRedMultiChannelCurve curve)
            {
                var interpolation = dictionary["InterpolationType"];
                var interpolationByte = int.Parse(interpolation.ToString());

                throw new NotImplementedException();

                //curve.SetInterpolationType((EInterpolationType)interpolationByte);

                //var link = dictionary["LinkType"];
                //var linkByte = int.Parse(link.ToString());
                //curve.SetLinkType((ESegmentsLinkType)linkByte);

                //curve.SetFromJObject(dictionary["Elements"]);

                //return;
            }

            foreach (var (propertyName, value) in dictionary)
            {
                var redProperty = GetRedProperty(cvar, propertyName);
                if (redProperty == null)
                {
                    throw new InvalidParsingException("not a CVariable");
                }
                redProperty.SetFromJObject(value);
            }
        }

        private static IRedType GetRedProperty(IRedType cvar, string propertyName)
        {
            throw new NotImplementedException();
            //foreach (var member in REDReflection.GetMembers(cvar))
            //{
            //    try
            //    {
            //        var redname = REDReflection.GetREDNameString(member);
            //        if (redname != propertyName)
            //        {
            //            continue;
            //        }

            //        var prop = cvar.accessor[cvar, member.Name];
            //        var cprop = prop as IRedType;

            //        return cprop;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //        throw;
            //    }
            //}

            //return null;
        }

        public static object ToObject(this IRedType data)
        {
            switch (data)
            {
                case CDateTime d:
                    return d.ToUInt64();
                // special cases of primitive types
                case CVariant var:
                    throw new NotImplementedException();
                //return new Dictionary<string, object>()
                //{
                //    {"Type", var.Variant.REDType},
                //    {"Variant", var.Variant.ToObject()}
                //};
                //case CVariantSizeNameType varnt:
                //    return new Dictionary<string, object>()
                //    {
                //        {"Type", varnt.Variant.REDType},
                //        {"Name", varnt.Variant.REDName},
                //        {"Variant", varnt.Variant.ToObject()}
                //    };
                //case IREDCurvePoint cp:
                //    if (cp.GetValue() is Tuple<IEditableVariable, IEditableVariable>(var item1, var item2))
                //    {
                //        return new Dictionary<string, object>() { { "Value", item1.ToObject() }, { "Point", item2.ToObject() } };
                //    }
                //    throw new InvalidParsingException($"{data.REDType} ToObject");
                // serialize arrays as list of objects
                // serialize curves as array
                case IRedArray arr:
                {
                    if (arr is IList ilist)
                    {
                        throw new NotImplementedException();
                        //if (arr.IsByteArray())
                        //{
                        //    return arr.GetBytes();
                        //}
                        //else
                        //{
                        //    return ilist.Cast<IRedType>().Select(_ => _.ToObject());
                        //}
                    }

                    throw new InvalidParsingException("Invalid File");
                }
                // serialize primitive types directly
                case IRedPrimitive b:
                    return b;
                case IRedMultiChannelCurve curve:
                {
                    dynamic array = data;
                    if (array.Elements is not IList dyn)
                    {
                        throw new InvalidParsingException("Invalid File");
                    }
                    var elements = dyn
                        .Cast<IRedType>()
                        .Select(_ => _.ToObject());

                    throw new NotImplementedException();
                    //return new Dictionary<string, object>()
                    //{
                    //    {"InterpolationType", curve.GetInterpolationType()},
                    //    {"LinkType", curve.GetLinkType()},
                    //    {"Elements", elements}
                    //};
                }

                // serialize complex properties as Dictionary
                default:
                    var dict = new Dictionary<string, object>();
                    throw new NotImplementedException();
                    //foreach (var cvar in data.SerializedProperties)
                    //{
                    //    dict.Add(cvar.REDName, cvar.ToObject());
                    //}

                    //return dict;
            }

        }
    }
}
