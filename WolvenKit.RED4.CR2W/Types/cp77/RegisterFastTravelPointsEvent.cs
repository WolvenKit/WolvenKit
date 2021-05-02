using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterFastTravelPointsEvent : redEvent
	{
		private CArray<CHandle<gameFastTravelPointData>> _fastTravelNodes;

		[Ordinal(0)] 
		[RED("fastTravelNodes")] 
		public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes
		{
			get => GetProperty(ref _fastTravelNodes);
			set => SetProperty(ref _fastTravelNodes, value);
		}

		public RegisterFastTravelPointsEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
