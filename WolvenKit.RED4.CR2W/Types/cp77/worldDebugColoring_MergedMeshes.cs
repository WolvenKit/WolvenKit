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
			get => GetProperty(ref _defaultColor);
			set => SetProperty(ref _defaultColor, value);
		}

		[Ordinal(1)] 
		[RED("mergedMeshColor")] 
		public CColor MergedMeshColor
		{
			get => GetProperty(ref _mergedMeshColor);
			set => SetProperty(ref _mergedMeshColor, value);
		}

		public worldDebugColoring_MergedMeshes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
