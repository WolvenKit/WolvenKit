using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SDevelopmentPoints : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataDevelopmentPointType> Type
		{
			get => GetPropertyValue<CEnum<gamedataDevelopmentPointType>>();
			set => SetPropertyValue<CEnum<gamedataDevelopmentPointType>>(value);
		}

		[Ordinal(1)] 
		[RED("spent")] 
		public CInt32 Spent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("unspent")] 
		public CInt32 Unspent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SDevelopmentPoints()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
