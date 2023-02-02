using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PassiveRoleCondition : AIbehaviorexpressionScript
	{
		[Ordinal(0)] 
		[RED("role")] 
		public CEnum<EAIRole> Role
		{
			get => GetPropertyValue<CEnum<EAIRole>>();
			set => SetPropertyValue<CEnum<EAIRole>>(value);
		}

		[Ordinal(1)] 
		[RED("roleCbId")] 
		public CUInt32 RoleCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public PassiveRoleCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
