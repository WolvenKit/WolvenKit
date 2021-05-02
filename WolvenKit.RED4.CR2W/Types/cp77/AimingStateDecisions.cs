using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AimingStateDecisions : UpperBodyTransition
	{
		private CFloat _mouseZoomLevel;

		[Ordinal(0)] 
		[RED("mouseZoomLevel")] 
		public CFloat MouseZoomLevel
		{
			get => GetProperty(ref _mouseZoomLevel);
			set => SetProperty(ref _mouseZoomLevel, value);
		}

		public AimingStateDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
