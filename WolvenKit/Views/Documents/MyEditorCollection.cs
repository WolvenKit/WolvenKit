using System;
using Syncfusion.Windows.PropertyGrid;

namespace WolvenKit.Views.Documents
{
    public class MyEditorCollection : CustomEditorCollection
    {
        public MyEditorCollection()
        {




            //Add(new CustomEditor { EditorType = typeof(IntegerEditor), HasPropertyType = true, PropertyType = typeof(CDouble) });
            //Add(new CustomEditor { EditorType = typeof(IntegerEditor), HasPropertyType = true, PropertyType = typeof(CUInt8) });
            //Add(new CustomEditor { EditorType = typeof(IntegerEditor), HasPropertyType = true, PropertyType = typeof(CInt8) });
            //Add(new CustomEditor { EditorType = typeof(IntegerEditor), HasPropertyType = true, PropertyType = typeof(CUInt16) });
            //Add(new CustomEditor { EditorType = typeof(IntegerEditor), HasPropertyType = true, PropertyType = typeof(CInt16) });
            //Add(new CustomEditor { EditorType = typeof(IntegerEditor), HasPropertyType = true, PropertyType = typeof(CUInt32) });
            //Add(new CustomEditor { EditorType = typeof(IntegerEditor), HasPropertyType = true, PropertyType = typeof(CInt32) });
            //Add(new CustomEditor { EditorType = typeof(IntegerEditor), HasPropertyType = true, PropertyType = typeof(CUInt64) });
            //Add(new CustomEditor { EditorType = typeof(IntegerEditor), HasPropertyType = true, PropertyType = typeof(CInt64) });

            //Add(new CustomEditor { EditorType = typeof(FloatEditor), HasPropertyType = true, PropertyType = typeof(CFloat) });

            // strings
            //Add(new CustomEditor { EditorType = typeof(TextEditor), HasPropertyType = true, PropertyType = typeof(CString) });
            //Add(new CustomEditor { EditorType = typeof(TextEditor), HasPropertyType = true, PropertyType = typeof(CName) });
            //Add(new CustomEditor { EditorType = typeof(TextEditor), HasPropertyType = true, PropertyType = typeof(NodeRef) });

            //bool
            //Add(new CustomEditor { EditorType = typeof(BoolEditor), HasPropertyType = true, PropertyType = typeof(CBool) });

            //IREDChunkPtr

            //IREDRef

            //IREDColor

            //IREDEnum

            //ICurveDataAccessor
        }


        public new ITypeCustomEditor this[Type PropertyType]
        {
            get
            {
                for (var i = 0; i < base.Items.Count; i++)
                {
                    _ = base.Items[i];
                }

                return null;
            }
        }

        public new ITypeCustomEditor this[string PropertyName, Type PropertyType]
        {
            get
            {
                for (var i = 0; i < base.Items.Count; i++)
                {
                    ITypeCustomEditor typeCustomEditor = base.Items[i];
                    if (typeCustomEditor.HasPropertyType)
                    {
                        if (typeCustomEditor.PropertyType.Equals(PropertyType))
                        {
                            return base.Items[i];
                        }
                    }
                    else if (typeCustomEditor.Properties.Contains(PropertyName))
                    {
                        return base.Items[i];
                    }
                }

                return null;
            }
        }
    }
}
