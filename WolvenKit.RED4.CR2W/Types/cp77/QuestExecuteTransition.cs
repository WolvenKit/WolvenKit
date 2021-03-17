using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestExecuteTransition : redEvent
	{
		private AreaTypeTransition _transition;

		[Ordinal(0)] 
		[RED("transition")] 
		public AreaTypeTransition Transition
		{
			get => GetProperty(ref _transition);
			set => SetProperty(ref _transition, value);
		}

		public QuestExecuteTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
