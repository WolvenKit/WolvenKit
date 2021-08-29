using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PassiveIsPlayerCompanionCondition : PassiveAutonomousCondition
	{
		private CUInt32 _roleCbId;

		[Ordinal(0)] 
		[RED("roleCbId")] 
		public CUInt32 RoleCbId
		{
			get => GetProperty(ref _roleCbId);
			set => SetProperty(ref _roleCbId, value);
		}
	}
}
