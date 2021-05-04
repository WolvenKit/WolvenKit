using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpenWorldMapDeviceAction : ActionBool
	{
		private CHandle<gameFastTravelPointData> _fastTravelPointData;

		[Ordinal(25)] 
		[RED("fastTravelPointData")] 
		public CHandle<gameFastTravelPointData> FastTravelPointData
		{
			get => GetProperty(ref _fastTravelPointData);
			set => SetProperty(ref _fastTravelPointData, value);
		}

		public OpenWorldMapDeviceAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
