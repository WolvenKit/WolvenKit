using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatPoolSpentPrereqListener : BaseStatPoolPrereqListener
	{
		private CWeakHandle<StatPoolSpentPrereqState> _state;
		private CFloat _overallSpentValue;

		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<StatPoolSpentPrereqState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("overallSpentValue")] 
		public CFloat OverallSpentValue
		{
			get => GetProperty(ref _overallSpentValue);
			set => SetProperty(ref _overallSpentValue, value);
		}
	}
}
