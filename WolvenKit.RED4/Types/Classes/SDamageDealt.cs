using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SDamageDealt : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataDamageType> Type
		{
			get => GetPropertyValue<CEnum<gamedataDamageType>>();
			set => SetPropertyValue<CEnum<gamedataDamageType>>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("affectedStatPool")] 
		public CEnum<gamedataStatPoolType> AffectedStatPool
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		public SDamageDealt()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
