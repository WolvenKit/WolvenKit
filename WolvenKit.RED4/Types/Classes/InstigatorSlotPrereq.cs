using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InstigatorSlotPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("slot")] 
		public TweakDBID Slot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public InstigatorSlotPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
