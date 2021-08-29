using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterReaction_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _puppetRef;
		private CBool _isAnyReaction;
		private TweakDBID _reactionBehaviorID;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("isAnyReaction")] 
		public CBool IsAnyReaction
		{
			get => GetProperty(ref _isAnyReaction);
			set => SetProperty(ref _isAnyReaction, value);
		}

		[Ordinal(2)] 
		[RED("reactionBehaviorID")] 
		public TweakDBID ReactionBehaviorID
		{
			get => GetProperty(ref _reactionBehaviorID);
			set => SetProperty(ref _reactionBehaviorID, value);
		}
	}
}
