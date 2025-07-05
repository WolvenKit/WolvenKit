using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequestBuyAttribute : redEvent
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataStatType> Type
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		public RequestBuyAttribute()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
