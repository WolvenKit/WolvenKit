using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterReaction_ConditionType : questICharacterConditionType
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

		public questCharacterReaction_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
