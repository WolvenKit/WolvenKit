using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectSingleFilter_BlackboardBoolCondition : gameEffectObjectSingleFilter
	{
		private gameEffectInputParameter_Bool _parameter;
		private CHandle<gameEffectObjectSingleFilter> _filter;

		[Ordinal(0)] 
		[RED("parameter")] 
		public gameEffectInputParameter_Bool Parameter
		{
			get => GetProperty(ref _parameter);
			set => SetProperty(ref _parameter, value);
		}

		[Ordinal(1)] 
		[RED("filter")] 
		public CHandle<gameEffectObjectSingleFilter> Filter
		{
			get => GetProperty(ref _filter);
			set => SetProperty(ref _filter, value);
		}
	}
}
