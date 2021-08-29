using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIRoleCondition : AIbehaviorconditionScript
	{
		private CEnum<EAIRole> _role;

		[Ordinal(0)] 
		[RED("role")] 
		public CEnum<EAIRole> Role
		{
			get => GetProperty(ref _role);
			set => SetProperty(ref _role, value);
		}
	}
}
