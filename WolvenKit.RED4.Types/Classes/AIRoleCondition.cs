using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIRoleCondition : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("role")] 
		public CEnum<EAIRole> Role
		{
			get => GetPropertyValue<CEnum<EAIRole>>();
			set => SetPropertyValue<CEnum<EAIRole>>(value);
		}
	}
}
