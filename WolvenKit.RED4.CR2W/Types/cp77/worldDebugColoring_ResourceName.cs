using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_ResourceName : worldEditorDebugColoringSettings
	{
		private CArray<worldNameColorPair> _names;
		private CColor _defaultColor;

		[Ordinal(0)] 
		[RED("names")] 
		public CArray<worldNameColorPair> Names
		{
			get
			{
				if (_names == null)
				{
					_names = (CArray<worldNameColorPair>) CR2WTypeManager.Create("array:worldNameColorPair", "names", cr2w, this);
				}
				return _names;
			}
			set
			{
				if (_names == value)
				{
					return;
				}
				_names = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public worldDebugColoring_ResourceName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
