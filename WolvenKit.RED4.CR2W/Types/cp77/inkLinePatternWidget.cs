using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLinePatternWidget : inkImageWidget
	{
		private CArray<inkLineVertex> _vertexList;
		private CFloat _spacing;
		private CFloat _looseSpacing;
		private CFloat _startOffset;
		private CFloat _endOffset;
		private CFloat _fadeInLength;
		private CBool _rotateWithSegment;
		private CEnum<inkEChildOrder> _patternDirection;

		[Ordinal(30)] 
		[RED("vertexList")] 
		public CArray<inkLineVertex> VertexList
		{
			get
			{
				if (_vertexList == null)
				{
					_vertexList = (CArray<inkLineVertex>) CR2WTypeManager.Create("array:inkLineVertex", "vertexList", cr2w, this);
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

		[Ordinal(31)] 
		[RED("spacing")] 
		public CFloat Spacing
		{
			get
			{
				if (_spacing == null)
				{
					_spacing = (CFloat) CR2WTypeManager.Create("Float", "spacing", cr2w, this);
				}
				return _spacing;
			}
			set
			{
				if (_spacing == value)
				{
					return;
				}
				_spacing = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("looseSpacing")] 
		public CFloat LooseSpacing
		{
			get
			{
				if (_looseSpacing == null)
				{
					_looseSpacing = (CFloat) CR2WTypeManager.Create("Float", "looseSpacing", cr2w, this);
				}
				return _looseSpacing;
			}
			set
			{
				if (_looseSpacing == value)
				{
					return;
				}
				_looseSpacing = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("startOffset")] 
		public CFloat StartOffset
		{
			get
			{
				if (_startOffset == null)
				{
					_startOffset = (CFloat) CR2WTypeManager.Create("Float", "startOffset", cr2w, this);
				}
				return _startOffset;
			}
			set
			{
				if (_startOffset == value)
				{
					return;
				}
				_startOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("endOffset")] 
		public CFloat EndOffset
		{
			get
			{
				if (_endOffset == null)
				{
					_endOffset = (CFloat) CR2WTypeManager.Create("Float", "endOffset", cr2w, this);
				}
				return _endOffset;
			}
			set
			{
				if (_endOffset == value)
				{
					return;
				}
				_endOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("fadeInLength")] 
		public CFloat FadeInLength
		{
			get
			{
				if (_fadeInLength == null)
				{
					_fadeInLength = (CFloat) CR2WTypeManager.Create("Float", "fadeInLength", cr2w, this);
				}
				return _fadeInLength;
			}
			set
			{
				if (_fadeInLength == value)
				{
					return;
				}
				_fadeInLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("rotateWithSegment")] 
		public CBool RotateWithSegment
		{
			get
			{
				if (_rotateWithSegment == null)
				{
					_rotateWithSegment = (CBool) CR2WTypeManager.Create("Bool", "rotateWithSegment", cr2w, this);
				}
				return _rotateWithSegment;
			}
			set
			{
				if (_rotateWithSegment == value)
				{
					return;
				}
				_rotateWithSegment = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("patternDirection")] 
		public CEnum<inkEChildOrder> PatternDirection
		{
			get
			{
				if (_patternDirection == null)
				{
					_patternDirection = (CEnum<inkEChildOrder>) CR2WTypeManager.Create("inkEChildOrder", "patternDirection", cr2w, this);
				}
				return _patternDirection;
			}
			set
			{
				if (_patternDirection == value)
				{
					return;
				}
				_patternDirection = value;
				PropertySet(this);
			}
		}

		public inkLinePatternWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
