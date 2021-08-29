using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PassiveRoleCondition : AIbehaviorexpressionScript
	{
		private CEnum<EAIRole> _role;
		private CUInt32 _roleCbId;

		[Ordinal(0)] 
		[RED("role")] 
		public CEnum<EAIRole> Role
		{
			get => GetProperty(ref _role);
			set => SetProperty(ref _role, value);
		}

		[Ordinal(1)] 
		[RED("roleCbId")] 
		public CUInt32 RoleCbId
		{
			get => GetProperty(ref _roleCbId);
			set => SetProperty(ref _roleCbId, value);
		}
	}
}
