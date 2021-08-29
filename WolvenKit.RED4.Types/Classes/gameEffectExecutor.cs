using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor : gameEffectNode
	{
		private CBool _usesHitCooldown;

		[Ordinal(0)] 
		[RED("usesHitCooldown")] 
		public CBool UsesHitCooldown
		{
			get => GetProperty(ref _usesHitCooldown);
			set => SetProperty(ref _usesHitCooldown, value);
		}
	}
}
