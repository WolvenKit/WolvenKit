using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRootHudGameController : gameuiWidgetGameController
	{
		private CArray<inkCompoundWidgetReference> _resolutionSensitiveRoots;

		[Ordinal(2)] 
		[RED("resolutionSensitiveRoots")] 
		public CArray<inkCompoundWidgetReference> ResolutionSensitiveRoots
		{
			get => GetProperty(ref _resolutionSensitiveRoots);
			set => SetProperty(ref _resolutionSensitiveRoots, value);
		}

		public gameuiRootHudGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
