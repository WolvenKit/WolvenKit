using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_MergedMeshes : worldEditorDebugColoringSettings
	{
		private CColor _defaultColor;
		private CColor _mergedMeshColor;

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

		[Ordinal(1)] 
		[RED("mergedMeshColor")] 
		public CColor MergedMeshColor
		{
			get
			{
				if (_mergedMeshColor == null)
				{
					_mergedMeshColor = (CColor) CR2WTypeManager.Create("Color", "mergedMeshColor", cr2w, this);
				}
				return _mergedMeshColor;
			}
			set
			{
				if (_mergedMeshColor == value)
				{
					return;
				}
				_mergedMeshColor = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_MergedMeshes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
