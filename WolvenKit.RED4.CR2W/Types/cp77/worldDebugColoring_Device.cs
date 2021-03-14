using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_Device : worldEditorDebugColoringSettings
	{
		private CColor _defaultColor;

		[Ordinal(0)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get
			{
				if (_defaultColor == null)
				{
					_defaultColor = (CColor) CR2WTypeManager.Create("Color", "defaultColor", cr2w, this);
				}
				return _defaultColor;
			}
			set
			{
				if (_defaultColor == value)
				{
					return;
				}
				_defaultColor = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_Device(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
