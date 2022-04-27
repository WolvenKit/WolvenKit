using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TargetNPCTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gamedataNPCType> Type
		{
			get => GetPropertyValue<CEnum<gamedataNPCType>>();
			set => SetPropertyValue<CEnum<gamedataNPCType>>(value);
		}

		public TargetNPCTypeHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
