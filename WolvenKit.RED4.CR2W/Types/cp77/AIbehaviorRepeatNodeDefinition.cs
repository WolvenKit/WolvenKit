using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorRepeatNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _limit;
		private CBool _repeatChildOnFailure;

		[Ordinal(1)] 
		[RED("limit")] 
		public CHandle<AIArgumentMapping> Limit
		{
			get => GetProperty(ref _limit);
			set => SetProperty(ref _limit, value);
		}

		[Ordinal(2)] 
		[RED("repeatChildOnFailure")] 
		public CBool RepeatChildOnFailure
		{
			get => GetProperty(ref _repeatChildOnFailure);
			set => SetProperty(ref _repeatChildOnFailure, value);
		}

		public AIbehaviorRepeatNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
