using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReactionManagerTask : AIbehaviortaskScript
	{
		private CHandle<AIReactionData> _reactionData;

		[Ordinal(0)] 
		[RED("reactionData")] 
		public CHandle<AIReactionData> ReactionData
		{
			get => GetProperty(ref _reactionData);
			set => SetProperty(ref _reactionData, value);
		}

		public ReactionManagerTask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
