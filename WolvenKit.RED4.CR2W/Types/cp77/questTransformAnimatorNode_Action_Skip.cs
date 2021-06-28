using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTransformAnimatorNode_Action_Skip : questTransformAnimatorNode_ActionType
	{
		private CFloat _skipTo;
		private CBool _skipToEnd;

		[Ordinal(0)] 
		[RED("skipTo")] 
		public CFloat SkipTo
		{
			get => GetProperty(ref _skipTo);
			set => SetProperty(ref _skipTo, value);
		}

		[Ordinal(1)] 
		[RED("skipToEnd")] 
		public CBool SkipToEnd
		{
			get => GetProperty(ref _skipToEnd);
			set => SetProperty(ref _skipToEnd, value);
		}

		public questTransformAnimatorNode_Action_Skip(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
