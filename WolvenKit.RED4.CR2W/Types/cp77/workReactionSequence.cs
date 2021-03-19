using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workReactionSequence : workIContainerEntry
	{
		private CFloat _forcedBlendIn;
		private CArray<TweakDBID> _reactionTypes;
		private CName _mainEmotionalState;
		private CName _emotionalExpression;
		private CFloat _facialKeyWeight;
		private CName _facialIdleMaleAnimation;
		private CName _facialIdleKey_MaleAnimation;
		private CName _facialIdleFemaleAnimation;
		private CName _facialIdleKey_FemaleAnimation;

		[Ordinal(4)] 
		[RED("forcedBlendIn")] 
		public CFloat ForcedBlendIn
		{
			get => GetProperty(ref _forcedBlendIn);
			set => SetProperty(ref _forcedBlendIn, value);
		}

		[Ordinal(5)] 
		[RED("reactionTypes")] 
		public CArray<TweakDBID> ReactionTypes
		{
			get => GetProperty(ref _reactionTypes);
			set => SetProperty(ref _reactionTypes, value);
		}

		[Ordinal(6)] 
		[RED("mainEmotionalState")] 
		public CName MainEmotionalState
		{
			get => GetProperty(ref _mainEmotionalState);
			set => SetProperty(ref _mainEmotionalState, value);
		}

		[Ordinal(7)] 
		[RED("emotionalExpression")] 
		public CName EmotionalExpression
		{
			get => GetProperty(ref _emotionalExpression);
			set => SetProperty(ref _emotionalExpression, value);
		}

		[Ordinal(8)] 
		[RED("facialKeyWeight")] 
		public CFloat FacialKeyWeight
		{
			get => GetProperty(ref _facialKeyWeight);
			set => SetProperty(ref _facialKeyWeight, value);
		}

		[Ordinal(9)] 
		[RED("facialIdleMaleAnimation")] 
		public CName FacialIdleMaleAnimation
		{
			get => GetProperty(ref _facialIdleMaleAnimation);
			set => SetProperty(ref _facialIdleMaleAnimation, value);
		}

		[Ordinal(10)] 
		[RED("facialIdleKey_MaleAnimation")] 
		public CName FacialIdleKey_MaleAnimation
		{
			get => GetProperty(ref _facialIdleKey_MaleAnimation);
			set => SetProperty(ref _facialIdleKey_MaleAnimation, value);
		}

		[Ordinal(11)] 
		[RED("facialIdleFemaleAnimation")] 
		public CName FacialIdleFemaleAnimation
		{
			get => GetProperty(ref _facialIdleFemaleAnimation);
			set => SetProperty(ref _facialIdleFemaleAnimation, value);
		}

		[Ordinal(12)] 
		[RED("facialIdleKey_FemaleAnimation")] 
		public CName FacialIdleKey_FemaleAnimation
		{
			get => GetProperty(ref _facialIdleKey_FemaleAnimation);
			set => SetProperty(ref _facialIdleKey_FemaleAnimation, value);
		}

		public workReactionSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
