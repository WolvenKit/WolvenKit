using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TriggerDelayedReactionEvent : DelayedCrowdReactionEvent
	{
		private CBool _initAnim;
		private CEnum<gamedataOutput> _behavior;

		[Ordinal(2)] 
		[RED("initAnim")] 
		public CBool InitAnim
		{
			get => GetProperty(ref _initAnim);
			set => SetProperty(ref _initAnim, value);
		}

		[Ordinal(3)] 
		[RED("behavior")] 
		public CEnum<gamedataOutput> Behavior
		{
			get => GetProperty(ref _behavior);
			set => SetProperty(ref _behavior, value);
		}
	}
}
