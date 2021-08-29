using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PassiveGlobalDeathCondition : AIbehaviorexpressionScript
	{
		private CUInt32 _onDeathCbId;

		[Ordinal(0)] 
		[RED("onDeathCbId")] 
		public CUInt32 OnDeathCbId
		{
			get => GetProperty(ref _onDeathCbId);
			set => SetProperty(ref _onDeathCbId, value);
		}
	}
}
