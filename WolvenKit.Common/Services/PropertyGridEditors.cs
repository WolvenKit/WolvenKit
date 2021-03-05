using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.Common.Services
{
    // Use interfaces for each PropertyEditor Service
    // all PropertyEditors must implement the IPropertyEditorBase interface
    // Register PropertyEditor implementations to the UI at ModuleInitializer
    // PropertyEditor implementations are in the UI part of the project and are resolved with IoC
    // IEditable variables use the IExpandableObjectEditor by default, 
    // specific classes must override this with [Editor(typeof(INumericEditor), typeof(IPropertyEditorBase))]

    public interface IPropertyEditorBase { }

    public interface IExpandableObjectEditor : IPropertyEditorBase { }

    public interface ICollectionEditor : IPropertyEditorBase { }

    /// <summary>
    /// Editors for numeric wrappers (T ... double)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITextEditor<T> : IPropertyEditorBase { }

    /// <summary>
    /// Editors for CBool
    /// </summary>
    public interface IBoolEditor : IPropertyEditorBase { }

    /// <summary>
    /// Editors for CBool
    /// </summary>
    public interface IEnumEditor : IPropertyEditorBase { }


}
