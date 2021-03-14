using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_GIDebug : worldEditorDebugColoringSettings
	{
		private CColor _gIVisibleColor;
		private CColor _gITransparentColor;

		[Ordinal(0)] 
		[RED("GIVisibleColor")] 
		public CColor GIVisibleColor
		{
			get
			{
				if (_gIVisibleColor == null)
				{
					_gIVisibleColor = (CColor) CR2WTypeManager.Create("Color", "GIVisibleColor", cr2w, this);
				}
				return _gIVisibleColor;
			}
			set
			{
				if (_gIVisibleColor == value)
				{
					return;
				}
				_gIVisibleColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("GITransparentColor")] 
		public CColor GITransparentColor
		{
			get
			{
				if (_gITransparentColor == null)
				{
					_gITransparentColor = (CColor) CR2WTypeManager.Create("Color", "GITransparentColor", cr2w, this);
				}
				return _gITransparentColor;
			}
			set
			{
				if (_gITransparentColor == value)
				{
					return;
				}
				_gITransparentColor = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_GIDebug(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
