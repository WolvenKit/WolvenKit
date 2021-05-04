using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestRemoveTransition : redEvent
	{
		private CInt32 _removeTransitionFrom;

		[Ordinal(0)] 
		[RED("removeTransitionFrom")] 
		public CInt32 RemoveTransitionFrom
		{
			get => GetProperty(ref _removeTransitionFrom);
			set => SetProperty(ref _removeTransitionFrom, value);
		}

		public QuestRemoveTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
