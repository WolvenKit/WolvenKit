using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPoolSpentPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(1)] 
		[RED("valueToCheck")] 
		public CFloat ValueToCheck
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public StatPoolSpentPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
