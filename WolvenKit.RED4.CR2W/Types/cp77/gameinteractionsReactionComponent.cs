using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsReactionComponent : entIComponent
	{
		private CArray<gameinteractionsReactionData> _reactions;
		private CBool _triggerAutomatically;

		[Ordinal(3)] 
		[RED("reactions")] 
		public CArray<gameinteractionsReactionData> Reactions
		{
			get => GetProperty(ref _reactions);
			set => SetProperty(ref _reactions, value);
		}

		[Ordinal(4)] 
		[RED("triggerAutomatically")] 
		public CBool TriggerAutomatically
		{
			get => GetProperty(ref _triggerAutomatically);
			set => SetProperty(ref _triggerAutomatically, value);
		}

		public gameinteractionsReactionComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
