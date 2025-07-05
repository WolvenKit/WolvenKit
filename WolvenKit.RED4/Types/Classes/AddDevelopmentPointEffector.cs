using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddDevelopmentPointEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataDevelopmentPointType> Type
		{
			get => GetPropertyValue<CEnum<gamedataDevelopmentPointType>>();
			set => SetPropertyValue<CEnum<gamedataDevelopmentPointType>>(value);
		}

		[Ordinal(2)] 
		[RED("tdbid")] 
		public TweakDBID Tdbid
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public AddDevelopmentPointEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
