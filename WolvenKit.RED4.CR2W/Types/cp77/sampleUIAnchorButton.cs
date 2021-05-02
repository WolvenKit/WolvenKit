using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIAnchorButton : inkWidgetLogicController
	{
		private CEnum<inkEAnchor> _anchorLocation;

		[Ordinal(1)] 
		[RED("anchorLocation")] 
		public CEnum<inkEAnchor> AnchorLocation
		{
			get => GetProperty(ref _anchorLocation);
			set => SetProperty(ref _anchorLocation, value);
		}

		public sampleUIAnchorButton(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
