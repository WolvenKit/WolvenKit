using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyStatPoolValueQuickhackCostEffector : HitEventEffector
	{
		[Ordinal(0)] 
		[RED("statPoolValue")] 
		public CFloat StatPoolValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(2)] 
		[RED("recoverMemoryAmount")] 
		public CFloat RecoverMemoryAmount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("skipLastCombatHack")] 
		public CBool SkipLastCombatHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ModifyStatPoolValueQuickhackCostEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
