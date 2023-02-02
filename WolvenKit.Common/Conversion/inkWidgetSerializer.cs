using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Conversion
{
    public class inkWidgetSerializer : IXmlSerializable
    {
        public inkWidget? Root;

        public inkWidgetSerializer()
        {

        }

        public inkWidgetSerializer(inkWidget widget) => Root = widget;

        public XmlSchema? GetSchema() => null;

        public void ReadXml(XmlReader reader) => throw new NotImplementedException();

        public void WriteXml(XmlWriter writer)
        {
            if (Root != null)
            {
                WriteWidget(writer, Root);
            }
        }

        public void WriteWidget(XmlWriter writer, inkWidget widget)
        {
            writer.WriteStartElement(widget.GetType().Name);

            WriteWidgetAttributes(writer, widget);

            if (widget is inkCompoundWidget compoundWidget)
            {
                var imc = (inkMultiChildren)compoundWidget.Children.GetValue();
                foreach (var childHandle in imc.Children)
                {
                    ArgumentNullException.ThrowIfNull(childHandle);

                    var child = (inkWidget)childHandle.GetValue();
                    WriteWidget(writer, child);
                }
            }

            writer.WriteEndElement();
        }

        public void WriteWidgetAttributes(XmlWriter writer, IRedType value, string property = "")
        {
            if (property != "")
            {
                property += ".";
            }

            var childSets = new List<IRedType>();

            var pis = RedReflection.GetTypeInfo(value).PropertyInfos.Sort((a, b) => a.Name.CompareTo(b.Name));
            pis.ForEach((pi) =>
            {
                var name = !string.IsNullOrEmpty(pi.RedName) ? pi.RedName : pi.Name;
                var propertyValue = ((RedBaseClass)value).GetProperty(name);

                if (!RedReflection.IsDefault(value.GetType(), pi, propertyValue))
                {
                    var propertyName = pi.RedName;
                    switch (propertyName)
                    {
                        case "children":
                        case "backendData":
                        case "parentWidget":
                            return;
                        default:
                            break;
                    }

                    switch (propertyValue)
                    {
                        case IRedBaseHandle handle:
                            var resolvedValue = handle.GetValue();
                            if (resolvedValue is inkWidget widget)
                            {
                                writer.WriteAttributeString(property + propertyName + "Path", widget.GetPath());
                            }
                            else
                            {
                                WriteWidgetAttributes(writer, resolvedValue, property + propertyName);
                            }
                            break;
                        case inkWidgetReference inkRef:
                            if (inkRef.Widget != null && inkRef.Widget.GetValue() is inkWidget widgetRef)
                            {
                                writer.WriteAttributeString(property + propertyName, widgetRef.GetPath());
                            }
                            break;
                        case CArray<CHandle<inkIEffect>>:
                        case CArray<CHandle<inkWidgetLogicController>>:
                        case CArray<CHandle<inkUserData>>:
                            childSets.Add(propertyValue);
                            break;
                        case CArray<inkPropertyBinding> ary:
                            //writer.WriteStartElement("bindings");
                            foreach (var ipb in ary)
                            {
                                ArgumentNullException.ThrowIfNull(ipb);

                                //writer.WriteStartElement("propertyBinding");
                                writer.WriteAttributeString(ipb.PropertyName + ".binding", ipb.StylePath);
                                //writer.WriteEndElement();
                            }
                            //writer.WriteEndElement();
                            break;
                        case inkMargin margin:
                            writer.WriteAttributeString(property + propertyName, margin.Left + "," + margin.Top + "," + margin.Right + "," + margin.Bottom);
                            break;
                        case inkUITransform:
                        case inkWidgetLayout:
                        case textWrappingInfo:
                            WriteWidgetAttributes(writer, propertyValue, property + propertyName);
                            break;
                        case LocalizationString lockey:
                            writer.WriteAttributeString(property + propertyName, lockey.Value.ToString());
                            break;
                        case HDRColor color:
                            writer.WriteAttributeString(property + propertyName, $"color(srgb {color.Red} {color.Green} {color.Blue} / {color.Alpha})");
                            //writer.WriteAttributeString(property + propertyName + ".Red", color.Red.ToString());
                            //writer.WriteAttributeString(property + propertyName + ".Green", color.Green.ToString());
                            //writer.WriteAttributeString(property + propertyName + ".Blue", color.Blue.ToString());
                            //writer.WriteAttributeString(property + propertyName + ".Alpha", color.Alpha.ToString());
                            break;
                        case Vector2 vector2:
                            writer.WriteAttributeString(property + propertyName, $"{vector2.X},{vector2.Y}");
                            //writer.WriteAttributeString(property + propertyName + ".X", vector2.X.ToString());
                            //writer.WriteAttributeString(property + propertyName + ".Y", vector2.Y.ToString());
                            break;
                        default:
                            writer.WriteAttributeString(property + propertyName, propertyValue?.ToString());
                            break;
                    }
                }
            });

            foreach (var childSet in childSets)
            {
                switch (childSet)
                {
                    case CArray<CHandle<inkIEffect>> effects:

                        writer.WriteStartElement("effects");
                        foreach (var handle in effects)
                        {
                            ArgumentNullException.ThrowIfNull(handle);

                            var effect = handle.GetValue();

                            writer.WriteStartElement(effect.GetType().Name);
                            WriteWidgetAttributes(writer, effect);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                        break;
                    case CArray<CHandle<inkWidgetLogicController>> controllers:

                        writer.WriteStartElement("secondaryControllers");
                        foreach (var handle in controllers)
                        {
                            ArgumentNullException.ThrowIfNull(handle);

                            var controller = handle.GetValue();

                            writer.WriteStartElement(controller.GetType().Name);
                            WriteWidgetAttributes(writer, controller);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                        break;
                    case CArray<CHandle<inkUserData>> ary:

                        writer.WriteStartElement("userData");
                        foreach (var handle in ary)
                        {
                            ArgumentNullException.ThrowIfNull(handle);

                            var item = handle.GetValue();

                            writer.WriteStartElement(item.GetType().Name);
                            WriteWidgetAttributes(writer, item);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
