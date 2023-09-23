using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetCustomPersonalLinkReason : ScriptableDeviceAction
	{
		[Ordinal(38)] 
		[RED("reason")] 
		public TweakDBID Reason
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public SetCustomPersonalLinkReason()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
