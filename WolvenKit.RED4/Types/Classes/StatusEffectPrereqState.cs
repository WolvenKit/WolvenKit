using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatusEffectPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("prereq")] 
		public CHandle<StatusEffectPrereq> Prereq
		{
			get => GetPropertyValue<CHandle<StatusEffectPrereq>>();
			set => SetPropertyValue<CHandle<StatusEffectPrereq>>(value);
		}

		[Ordinal(1)] 
		[RED("listener")] 
		public CHandle<StatusEffectPrereqListener> Listener
		{
			get => GetPropertyValue<CHandle<StatusEffectPrereqListener>>();
			set => SetPropertyValue<CHandle<StatusEffectPrereqListener>>(value);
		}

		public StatusEffectPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
