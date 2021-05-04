using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleWaterEvent : redEvent
	{
		private CBool _isInWater;

		[Ordinal(0)] 
		[RED("isInWater")] 
		public CBool IsInWater
		{
			get => GetProperty(ref _isInWater);
			set => SetProperty(ref _isInWater, value);
		}

		public vehicleWaterEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
