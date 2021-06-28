using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_ProxyMeshDependency : worldEditorDebugColoringSettings
	{
		private CColor _autoColor;
		private CColor _discardColor;

		[Ordinal(0)] 
		[RED("autoColor")] 
		public CColor AutoColor
		{
			get => GetProperty(ref _autoColor);
			set => SetProperty(ref _autoColor, value);
		}

		[Ordinal(1)] 
		[RED("discardColor")] 
		public CColor DiscardColor
		{
			get => GetProperty(ref _discardColor);
			set => SetProperty(ref _discardColor, value);
		}

		public worldDebugColoring_ProxyMeshDependency(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
