using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PassivePatrolConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)] 
		[RED("roleCbId")] 
		public CUInt32 RoleCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("cmdCbId")] 
		public CUInt32 CmdCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public PassivePatrolConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
