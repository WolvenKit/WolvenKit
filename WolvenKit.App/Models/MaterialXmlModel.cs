using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WolvenKit.App.Models;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false, ElementName = "mesh")]
public partial class MaterialXmlModel
{

    private MeshMesh_data? _mesh_dataField;

    private MeshMaterial[]? _materialsField;

    /// <remarks/>
    [XmlElement("mesh_data")]
    public MeshMesh_data? Mesh_data
    {
        get => _mesh_dataField;
        set => _mesh_dataField = value;
    }

    /// <remarks/>
    [XmlArrayItem(typeof(MeshMaterial), IsNullable = false, ElementName = "material")]
    [XmlArray("materials")]
    public MeshMaterial[]? Materials
    {
        get => _materialsField;
        set => _materialsField = value;
    }
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class MeshMesh_data
{

    private MeshMesh_dataLODs? _lODsField;

    private decimal _autohideDistanceField;

    /// <remarks/>
    [XmlElement("LODs")]
    public MeshMesh_dataLODs? LODs
    {
        get => _lODsField; set => _lODsField = value;
    }

    /// <remarks/>
    [XmlAttribute(AttributeName = "autohideDistance")]
    public decimal AutohideDistance
    {
        get => _autohideDistanceField; set => _autohideDistanceField = value;
    }
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class MeshMesh_dataLODs
{

    private MeshMesh_dataLODsLOD_info? _lOD_infoField;

    /// <remarks/>
    [XmlElement("LOD_info")]
    public MeshMesh_dataLODsLOD_info? LOD_info
    {
        get => _lOD_infoField; set => _lOD_infoField = value;
    }
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class MeshMesh_dataLODsLOD_info
{

    private decimal _distanceField;

    /// <remarks/>
    [XmlAttribute(AttributeName = "distance")]
    public decimal Distance
    {
        get => _distanceField; set => _distanceField = value;
    }
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class MeshMaterial
{

    private MeshMaterialParam[]? _paramField;

    private string? _nameField;

    private bool _localField;

    /// <remarks/>
    [XmlElement("param")]
    public MeshMaterialParam[]? Param
    {
        get => _paramField; set => _paramField = value;
    }

    /// <remarks/>
    [XmlAttribute(AttributeName = "name")]
    public string? Name
    {
        get => _nameField; set => _nameField = value;
    }

    /// <remarks/>
    [XmlAttribute(AttributeName = "local")]
    public bool Local
    {
        get => _localField; set => _localField = value;
    }
}

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class MeshMaterialParam
{

    private string? _nameField;

    private string? _typeField;

    private string? _valueField;

    /// <remarks/>
    [XmlAttribute(AttributeName = "name")]
    public string? Name
    {
        get => _nameField; set => _nameField = value;
    }

    /// <remarks/>
    [XmlAttribute(AttributeName = "type")]
    public string? Type
    {
        get => _typeField; set => _typeField = value;
    }

    /// <remarks/>
    [XmlAttribute(AttributeName = "value")]
    public string? Value
    {
        get => _valueField; set => _valueField = value;
    }
}

