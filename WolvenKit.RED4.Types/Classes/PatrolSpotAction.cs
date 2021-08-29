using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PatrolSpotAction : TweakAIActionSmartComposite
	{
		private CHandle<AIArgumentMapping> _patrolAction;

		[Ordinal(38)] 
		[RED("patrolAction")] 
		public CHandle<AIArgumentMapping> PatrolAction
		{
			get => GetProperty(ref _patrolAction);
			set => SetProperty(ref _patrolAction, value);
		}
	}
}
