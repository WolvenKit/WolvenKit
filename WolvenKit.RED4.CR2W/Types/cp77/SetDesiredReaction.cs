using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDesiredReaction : AIbehaviortaskScript
	{
		private CName _behaviorArgumentNameTag;
		private CName _behaviorArgumentFloatPriority;
		private CName _behaviorArgumentNameFlag;
		private CHandle<AIReactionData> _reactionData;

		[Ordinal(0)] 
		[RED("behaviorArgumentNameTag")] 
		public CName BehaviorArgumentNameTag
		{
			get => GetProperty(ref _behaviorArgumentNameTag);
			set => SetProperty(ref _behaviorArgumentNameTag, value);
		}

		[Ordinal(1)] 
		[RED("behaviorArgumentFloatPriority")] 
		public CName BehaviorArgumentFloatPriority
		{
			get => GetProperty(ref _behaviorArgumentFloatPriority);
			set => SetProperty(ref _behaviorArgumentFloatPriority, value);
		}

		[Ordinal(2)] 
		[RED("behaviorArgumentNameFlag")] 
		public CName BehaviorArgumentNameFlag
		{
			get => GetProperty(ref _behaviorArgumentNameFlag);
			set => SetProperty(ref _behaviorArgumentNameFlag, value);
		}

		[Ordinal(3)] 
		[RED("reactionData")] 
		public CHandle<AIReactionData> ReactionData
		{
			get => GetProperty(ref _reactionData);
			set => SetProperty(ref _reactionData, value);
		}

		public SetDesiredReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
