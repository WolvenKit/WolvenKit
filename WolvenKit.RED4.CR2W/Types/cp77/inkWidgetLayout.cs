using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLayout : CVariable
	{
		private inkMargin _padding;
		private inkMargin _margin;
		private CEnum<inkEHorizontalAlign> _hAlign;
		private CEnum<inkEVerticalAlign> _vAlign;
		private CEnum<inkEAnchor> _anchor;
		private Vector2 _anchorPoint;
		private CEnum<inkESizeRule> _sizeRule;
		private CFloat _sizeCoefficient;

		[Ordinal(0)] 
		[RED("padding")] 
		public inkMargin Padding
		{
			get
			{
				if (_padding == null)
				{
					_padding = (inkMargin) CR2WTypeManager.Create("inkMargin", "padding", cr2w, this);
				}
				return _padding;
			}
			set
			{
				if (_padding == value)
				{
					return;
				}
				_padding = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get
			{
				if (_margin == null)
				{
					_margin = (inkMargin) CR2WTypeManager.Create("inkMargin", "margin", cr2w, this);
				}
				return _margin;
			}
			set
			{
				if (_margin == value)
				{
					return;
				}
				_margin = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("HAlign")] 
		public CEnum<inkEHorizontalAlign> HAlign
		{
			get
			{
				if (_hAlign == null)
				{
					_hAlign = (CEnum<inkEHorizontalAlign>) CR2WTypeManager.Create("inkEHorizontalAlign", "HAlign", cr2w, this);
				}
				return _hAlign;
			}
			set
			{
				if (_hAlign == value)
				{
					return;
				}
				_hAlign = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("VAlign")] 
		public CEnum<inkEVerticalAlign> VAlign
		{
			get
			{
				if (_vAlign == null)
				{
					_vAlign = (CEnum<inkEVerticalAlign>) CR2WTypeManager.Create("inkEVerticalAlign", "VAlign", cr2w, this);
				}
				return _vAlign;
			}
			set
			{
				if (_vAlign == value)
				{
					return;
				}
				_vAlign = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("anchor")] 
		public CEnum<inkEAnchor> Anchor
		{
			get
			{
				if (_anchor == null)
				{
					_anchor = (CEnum<inkEAnchor>) CR2WTypeManager.Create("inkEAnchor", "anchor", cr2w, this);
				}
				return _anchor;
			}
			set
			{
				if (_anchor == value)
				{
					return;
				}
				_anchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("anchorPoint")] 
		public Vector2 AnchorPoint
		{
			get
			{
				if (_anchorPoint == null)
				{
					_anchorPoint = (Vector2) CR2WTypeManager.Create("Vector2", "anchorPoint", cr2w, this);
				}
				return _anchorPoint;
			}
			set
			{
				if (_anchorPoint == value)
				{
					return;
				}
				_anchorPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("sizeRule")] 
		public CEnum<inkESizeRule> SizeRule
		{
			get
			{
				if (_sizeRule == null)
				{
					_sizeRule = (CEnum<inkESizeRule>) CR2WTypeManager.Create("inkESizeRule", "sizeRule", cr2w, this);
				}
				return _sizeRule;
			}
			set
			{
				if (_sizeRule == value)
				{
					return;
				}
				_sizeRule = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("sizeCoefficient")] 
		public CFloat SizeCoefficient
		{
			get
			{
				if (_sizeCoefficient == null)
				{
					_sizeCoefficient = (CFloat) CR2WTypeManager.Create("Float", "sizeCoefficient", cr2w, this);
				}
				return _sizeCoefficient;
			}
			set
			{
				if (_sizeCoefficient == value)
				{
					return;
				}
				_sizeCoefficient = value;
				PropertySet(this);
			}
		}

		public inkWidgetLayout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
