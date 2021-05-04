using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleFlippedOverEvent : redEvent
	{
		private CBool _isFlippedOver;

		[Ordinal(0)] 
		[RED("isFlippedOver")] 
		public CBool IsFlippedOver
		{
			get => GetProperty(ref _isFlippedOver);
			set => SetProperty(ref _isFlippedOver, value);
		}

		public vehicleFlippedOverEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
