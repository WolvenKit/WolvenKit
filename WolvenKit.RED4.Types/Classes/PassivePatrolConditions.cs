using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PassivePatrolConditions : PassiveAutonomousCondition
	{
		private CUInt32 _roleCbId;
		private CUInt32 _cmdCbId;

		[Ordinal(0)] 
		[RED("roleCbId")] 
		public CUInt32 RoleCbId
		{
			get => GetProperty(ref _roleCbId);
			set => SetProperty(ref _roleCbId, value);
		}

		[Ordinal(1)] 
		[RED("cmdCbId")] 
		public CUInt32 CmdCbId
		{
			get => GetProperty(ref _cmdCbId);
			set => SetProperty(ref _cmdCbId, value);
		}
	}
}
