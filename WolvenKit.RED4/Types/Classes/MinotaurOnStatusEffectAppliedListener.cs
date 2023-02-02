using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinotaurOnStatusEffectAppliedListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<NPCPuppet> Owner
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("minotaurMechComponent")] 
		public CHandle<MinotaurMechComponent> MinotaurMechComponent
		{
			get => GetPropertyValue<CHandle<MinotaurMechComponent>>();
			set => SetPropertyValue<CHandle<MinotaurMechComponent>>(value);
		}

		public MinotaurOnStatusEffectAppliedListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
