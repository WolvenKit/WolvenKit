using System.Xml.Serialization;

namespace WolvenKit.App.Models;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "mesh")]
public partial class MaterialXmlModel
{

    private meshMesh_data? mesh_dataField;

    private meshMaterial[]? materialsField;

    /// <remarks/>
    public meshMesh_data? mesh_data
    {
        get
        {
            return mesh_dataField;
        }
        set
        {
            mesh_dataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("material", IsNullable = false)]
    public meshMaterial[]? materials
    {
        get
        {
            return materialsField;
        }
        set
        {
            materialsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class meshMesh_data
{

    private meshMesh_dataLODs? lODsField;

    private decimal autohideDistanceField;

    /// <remarks/>
    public meshMesh_dataLODs? LODs
    {
        get
        {
            return lODsField;
        }
        set
        {
            lODsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal autohideDistance
    {
        get
        {
            return autohideDistanceField;
        }
        set
        {
            autohideDistanceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class meshMesh_dataLODs
{

    private meshMesh_dataLODsLOD_info? lOD_infoField;

    /// <remarks/>
    public meshMesh_dataLODsLOD_info? LOD_info
    {
        get
        {
            return lOD_infoField;
        }
        set
        {
            lOD_infoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class meshMesh_dataLODsLOD_info
{

    private decimal distanceField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal distance
    {
        get
        {
            return distanceField;
        }
        set
        {
            distanceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class meshMaterial
{

    private meshMaterialParam[]? paramField;

    private string? nameField;

    private bool localField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("param")]
    public meshMaterialParam[]? param
    {
        get
        {
            return paramField;
        }
        set
        {
            paramField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string? name
    {
        get
        {
            return nameField;
        }
        set
        {
            nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool local
    {
        get
        {
            return localField;
        }
        set
        {
            localField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class meshMaterialParam
{

    private string? nameField;

    private string? typeField;

    private string? valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string? name
    {
        get
        {
            return nameField;
        }
        set
        {
            nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string? type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string? value
    {
        get
        {
            return valueField;
        }
        set
        {
            valueField = value;
        }
    }
}

