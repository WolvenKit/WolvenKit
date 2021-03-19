using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CanDoReactionAction : AIbehaviorconditionScript
	{
		private CName _reactionName;

		[Ordinal(0)] 
		[RED("reactionName")] 
		public CName ReactionName
		{
			get => GetProperty(ref _reactionName);
			set => SetProperty(ref _reactionName, value);
		}

		public CanDoReactionAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
