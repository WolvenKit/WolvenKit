using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_InteriorExterior : worldEditorDebugColoringSettings
	{
		private CColor _interiorColor;
		private CColor _openInteriorColor;
		private CColor _exteriorColor;

		[Ordinal(0)] 
		[RED("interiorColor")] 
		public CColor InteriorColor
		{
			get
			{
				if (_interiorColor == null)
				{
					_interiorColor = (CColor) CR2WTypeManager.Create("Color", "interiorColor", cr2w, this);
				}
				return _interiorColor;
			}
			set
			{
				if (_interiorColor == value)
				{
					return;
				}
				_interiorColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("openInteriorColor")] 
		public CColor OpenInteriorColor
		{
			get
			{
				if (_openInteriorColor == null)
				{
					_openInteriorColor = (CColor) CR2WTypeManager.Create("Color", "openInteriorColor", cr2w, this);
				}
				return _openInteriorColor;
			}
			set
			{
				if (_openInteriorColor == value)
				{
					return;
				}
				_openInteriorColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("exteriorColor")] 
		public CColor ExteriorColor
		{
			get
			{
				if (_exteriorColor == null)
				{
					_exteriorColor = (CColor) CR2WTypeManager.Create("Color", "exteriorColor", cr2w, this);
				}
				return _exteriorColor;
			}
			set
			{
				if (_exteriorColor == value)
				{
					return;
				}
				_exteriorColor = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_InteriorExterior(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
