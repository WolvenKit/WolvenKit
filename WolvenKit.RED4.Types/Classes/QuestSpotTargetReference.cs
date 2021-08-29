using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestSpotTargetReference : ActionEntityReference
	{
		private entEntityID _forcedTarget;

		[Ordinal(25)] 
		[RED("ForcedTarget")] 
		public entEntityID ForcedTarget
		{
			get => GetProperty(ref _forcedTarget);
			set => SetProperty(ref _forcedTarget, value);
		}
	}
}
