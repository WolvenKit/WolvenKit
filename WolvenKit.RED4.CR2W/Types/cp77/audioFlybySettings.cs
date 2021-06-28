using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFlybySettings : CVariable
	{
		private CFloat _movementSpeed;
		private CName _flybyEvent;

		[Ordinal(0)] 
		[RED("movementSpeed")] 
		public CFloat MovementSpeed
		{
			get => GetProperty(ref _movementSpeed);
			set => SetProperty(ref _movementSpeed, value);
		}

		[Ordinal(1)] 
		[RED("flybyEvent")] 
		public CName FlybyEvent
		{
			get => GetProperty(ref _flybyEvent);
			set => SetProperty(ref _flybyEvent, value);
		}

		public audioFlybySettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
