using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PassiveIsPlayerCompanionCondition : PassiveAutonomousCondition
	{
		[Ordinal(0)] 
		[RED("roleCbId")] 
		public CUInt32 RoleCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
