using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkDisplayData : BasePerkDisplayData
	{
		[Ordinal(10)] 
		[RED("area")] 
		public CEnum<gamedataPerkArea> Area
		{
			get => GetPropertyValue<CEnum<gamedataPerkArea>>();
			set => SetPropertyValue<CEnum<gamedataPerkArea>>(value);
		}

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<gamedataPerkType> Type
		{
			get => GetPropertyValue<CEnum<gamedataPerkType>>();
			set => SetPropertyValue<CEnum<gamedataPerkType>>(value);
		}

		public PerkDisplayData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
