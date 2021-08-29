using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorCompanionConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _spline;
		private CHandle<AIArgumentMapping> _companion;

		[Ordinal(1)] 
		[RED("spline")] 
		public CHandle<AIArgumentMapping> Spline
		{
			get => GetProperty(ref _spline);
			set => SetProperty(ref _spline, value);
		}

		[Ordinal(2)] 
		[RED("companion")] 
		public CHandle<AIArgumentMapping> Companion
		{
			get => GetProperty(ref _companion);
			set => SetProperty(ref _companion, value);
		}
	}
}
