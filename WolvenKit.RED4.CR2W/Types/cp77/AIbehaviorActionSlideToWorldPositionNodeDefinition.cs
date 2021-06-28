using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSlideToWorldPositionNodeDefinition : AIbehaviorActionSlideNodeDefinition
	{
		private CHandle<AIArgumentMapping> _worldPosition;
		private CBool _useMovePlanner;

		[Ordinal(4)] 
		[RED("worldPosition")] 
		public CHandle<AIArgumentMapping> WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}

		[Ordinal(5)] 
		[RED("useMovePlanner")] 
		public CBool UseMovePlanner
		{
			get => GetProperty(ref _useMovePlanner);
			set => SetProperty(ref _useMovePlanner, value);
		}

		public AIbehaviorActionSlideToWorldPositionNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
