using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterReactionAction : AIbehaviortaskScript
	{
		private CName _reactionName;
		private CBool _onDeactivation;

		[Ordinal(0)] 
		[RED("reactionName")] 
		public CName ReactionName
		{
			get => GetProperty(ref _reactionName);
			set => SetProperty(ref _reactionName, value);
		}

		[Ordinal(1)] 
		[RED("onDeactivation")] 
		public CBool OnDeactivation
		{
			get => GetProperty(ref _onDeactivation);
			set => SetProperty(ref _onDeactivation, value);
		}

		public UnregisterReactionAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
