using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkShapeWidget : inkBaseShapeWidget
	{
		private rRef<inkShapeCollectionResource> _shapeResource;
		private CName _shapeName;
		private CEnum<inkEShapeVariant> _shapeVariant;
		private CBool _keepInBounds;
		private inkMargin _nineSliceScale;
		private CBool _useNineSlice;
		private CEnum<inkEHorizontalAlign> _contentHAlign;
		private CEnum<inkEVerticalAlign> _contentVAlign;
		private HDRColor _borderColor;
		private CFloat _borderOpacity;
		private CFloat _fillOpacity;
		private CFloat _lineThickness;
		private CEnum<inkEEndCapStyle> _endCapStyle;
		private CEnum<inkEJointStyle> _jointStyle;
		private CArray<Vector2> _vertexList;

		[Ordinal(20)] 
		[RED("shapeResource")] 
		public rRef<inkShapeCollectionResource> ShapeResource
		{
			get
			{
				if (_shapeResource == null)
				{
					_shapeResource = (rRef<inkShapeCollectionResource>) CR2WTypeManager.Create("rRef:inkShapeCollectionResource", "shapeResource", cr2w, this);
				}
				return _shapeResource;
			}
			set
			{
				if (_shapeResource == value)
				{
					return;
				}
				_shapeResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("shapeName")] 
		public CName ShapeName
		{
			get
			{
				if (_shapeName == null)
				{
					_shapeName = (CName) CR2WTypeManager.Create("CName", "shapeName", cr2w, this);
				}
				return _shapeName;
			}
			set
			{
				if (_shapeName == value)
				{
					return;
				}
				_shapeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("shapeVariant")] 
		public CEnum<inkEShapeVariant> ShapeVariant
		{
			get
			{
				if (_shapeVariant == null)
				{
					_shapeVariant = (CEnum<inkEShapeVariant>) CR2WTypeManager.Create("inkEShapeVariant", "shapeVariant", cr2w, this);
				}
				return _shapeVariant;
			}
			set
			{
				if (_shapeVariant == value)
				{
					return;
				}
				_shapeVariant = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("keepInBounds")] 
		public CBool KeepInBounds
		{
			get
			{
				if (_keepInBounds == null)
				{
					_keepInBounds = (CBool) CR2WTypeManager.Create("Bool", "keepInBounds", cr2w, this);
				}
				return _keepInBounds;
			}
			set
			{
				if (_keepInBounds == value)
				{
					return;
				}
				_keepInBounds = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("nineSliceScale")] 
		public inkMargin NineSliceScale
		{
			get
			{
				if (_nineSliceScale == null)
				{
					_nineSliceScale = (inkMargin) CR2WTypeManager.Create("inkMargin", "nineSliceScale", cr2w, this);
				}
				return _nineSliceScale;
			}
			set
			{
				if (_nineSliceScale == value)
				{
					return;
				}
				_nineSliceScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("useNineSlice")] 
		public CBool UseNineSlice
		{
			get
			{
				if (_useNineSlice == null)
				{
					_useNineSlice = (CBool) CR2WTypeManager.Create("Bool", "useNineSlice", cr2w, this);
				}
				return _useNineSlice;
			}
			set
			{
				if (_useNineSlice == value)
				{
					return;
				}
				_useNineSlice = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("contentHAlign")] 
		public CEnum<inkEHorizontalAlign> ContentHAlign
		{
			get
			{
				if (_contentHAlign == null)
				{
					_contentHAlign = (CEnum<inkEHorizontalAlign>) CR2WTypeManager.Create("inkEHorizontalAlign", "contentHAlign", cr2w, this);
				}
				return _contentHAlign;
			}
			set
			{
				if (_contentHAlign == value)
				{
					return;
				}
				_contentHAlign = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("contentVAlign")] 
		public CEnum<inkEVerticalAlign> ContentVAlign
		{
			get
			{
				if (_contentVAlign == null)
				{
					_contentVAlign = (CEnum<inkEVerticalAlign>) CR2WTypeManager.Create("inkEVerticalAlign", "contentVAlign", cr2w, this);
				}
				return _contentVAlign;
			}
			set
			{
				if (_contentVAlign == value)
				{
					return;
				}
				_contentVAlign = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("borderColor")] 
		public HDRColor BorderColor
		{
			get
			{
				if (_borderColor == null)
				{
					_borderColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "borderColor", cr2w, this);
				}
				return _borderColor;
			}
			set
			{
				if (_borderColor == value)
				{
					return;
				}
				_borderColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("borderOpacity")] 
		public CFloat BorderOpacity
		{
			get
			{
				if (_borderOpacity == null)
				{
					_borderOpacity = (CFloat) CR2WTypeManager.Create("Float", "borderOpacity", cr2w, this);
				}
				return _borderOpacity;
			}
			set
			{
				if (_borderOpacity == value)
				{
					return;
				}
				_borderOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("fillOpacity")] 
		public CFloat FillOpacity
		{
			get
			{
				if (_fillOpacity == null)
				{
					_fillOpacity = (CFloat) CR2WTypeManager.Create("Float", "fillOpacity", cr2w, this);
				}
				return _fillOpacity;
			}
			set
			{
				if (_fillOpacity == value)
				{
					return;
				}
				_fillOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("lineThickness")] 
		public CFloat LineThickness
		{
			get
			{
				if (_lineThickness == null)
				{
					_lineThickness = (CFloat) CR2WTypeManager.Create("Float", "lineThickness", cr2w, this);
				}
				return _lineThickness;
			}
			set
			{
				if (_lineThickness == value)
				{
					return;
				}
				_lineThickness = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("endCapStyle")] 
		public CEnum<inkEEndCapStyle> EndCapStyle
		{
			get
			{
				if (_endCapStyle == null)
				{
					_endCapStyle = (CEnum<inkEEndCapStyle>) CR2WTypeManager.Create("inkEEndCapStyle", "endCapStyle", cr2w, this);
				}
				return _endCapStyle;
			}
			set
			{
				if (_endCapStyle == value)
				{
					return;
				}
				_endCapStyle = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("jointStyle")] 
		public CEnum<inkEJointStyle> JointStyle
		{
			get
			{
				if (_jointStyle == null)
				{
					_jointStyle = (CEnum<inkEJointStyle>) CR2WTypeManager.Create("inkEJointStyle", "jointStyle", cr2w, this);
				}
				return _jointStyle;
			}
			set
			{
				if (_jointStyle == value)
				{
					return;
				}
				_jointStyle = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("vertexList")] 
		public CArray<Vector2> VertexList
		{
			get
			{
				if (_vertexList == null)
				{
					_vertexList = (CArray<Vector2>) CR2WTypeManager.Create("array:Vector2", "vertexList", cr2w, this);
				}
				return _vertexList;
			}
			set
			{
				if (_vertexList == value)
				{
					return;
				}
				_vertexList = value;
				PropertySet(this);
			}
		}

		public inkShapeWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
