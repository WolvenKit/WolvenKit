using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkButtonTintController : inkButtonController
	{
		private CColor _normalColor;
		private CColor _hoverColor;
		private CColor _pressColor;
		private CColor _disableColor;
		private inkWidgetReference _tintControlRef;

		[Ordinal(10)] 
		[RED("NormalColor")] 
		public CColor NormalColor
		{
			get
			{
				if (_normalColor == null)
				{
					_normalColor = (CColor) CR2WTypeManager.Create("Color", "NormalColor", cr2w, this);
				}
				return _normalColor;
			}
			set
			{
				if (_normalColor == value)
				{
					return;
				}
				_normalColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("HoverColor")] 
		public CColor HoverColor
		{
			get
			{
				if (_hoverColor == null)
				{
					_hoverColor = (CColor) CR2WTypeManager.Create("Color", "HoverColor", cr2w, this);
				}
				return _hoverColor;
			}
			set
			{
				if (_hoverColor == value)
				{
					return;
				}
				_hoverColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("PressColor")] 
		public CColor PressColor
		{
			get
			{
				if (_pressColor == null)
				{
					_pressColor = (CColor) CR2WTypeManager.Create("Color", "PressColor", cr2w, this);
				}
				return _pressColor;
			}
			set
			{
				if (_pressColor == value)
				{
					return;
				}
				_pressColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("DisableColor")] 
		public CColor DisableColor
		{
			get
			{
				if (_disableColor == null)
				{
					_disableColor = (CColor) CR2WTypeManager.Create("Color", "DisableColor", cr2w, this);
				}
				return _disableColor;
			}
			set
			{
				if (_disableColor == value)
				{
					return;
				}
				_disableColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("TintControlRef")] 
		public inkWidgetReference TintControlRef
		{
			get
			{
				if (_tintControlRef == null)
				{
					_tintControlRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TintControlRef", cr2w, this);
				}
				return _tintControlRef;
			}
			set
			{
				if (_tintControlRef == value)
				{
					return;
				}
				_tintControlRef = value;
				PropertySet(this);
			}
		}

		public inkButtonTintController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
