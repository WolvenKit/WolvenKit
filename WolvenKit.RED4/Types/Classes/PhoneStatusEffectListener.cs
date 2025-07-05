using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneStatusEffectListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] 
		[RED("phoneSystem")] 
		public CWeakHandle<PhoneSystem> PhoneSystem
		{
			get => GetPropertyValue<CWeakHandle<PhoneSystem>>();
			set => SetPropertyValue<CWeakHandle<PhoneSystem>>(value);
		}

		public PhoneStatusEffectListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
