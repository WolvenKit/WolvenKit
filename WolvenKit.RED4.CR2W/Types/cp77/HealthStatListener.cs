using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HealthStatListener : gameScriptStatPoolsListener
	{
		private wCHandle<PlayerPuppet> _ownerPuppet;
		private CHandle<HealthUpdateEvent> _healthEvent;

		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public wCHandle<PlayerPuppet> OwnerPuppet
		{
			get => GetProperty(ref _ownerPuppet);
			set => SetProperty(ref _ownerPuppet, value);
		}

		[Ordinal(1)] 
		[RED("healthEvent")] 
		public CHandle<HealthUpdateEvent> HealthEvent
		{
			get => GetProperty(ref _healthEvent);
			set => SetProperty(ref _healthEvent, value);
		}

		public HealthStatListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
