using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GrenadeMappinData : gamemappinsMappinScriptData
	{
		[Ordinal(1)] 
		[RED("grenadeType")] 
		public CEnum<EGrenadeType> GrenadeType
		{
			get => GetPropertyValue<CEnum<EGrenadeType>>();
			set => SetPropertyValue<CEnum<EGrenadeType>>(value);
		}

		[Ordinal(2)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public GrenadeMappinData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
