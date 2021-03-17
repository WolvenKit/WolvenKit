using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestSpotTargetReference : ActionEntityReference
	{
		private entEntityID _forcedTarget;

		[Ordinal(25)] 
		[RED("ForcedTarget")] 
		public entEntityID ForcedTarget
		{
			get => GetProperty(ref _forcedTarget);
			set => SetProperty(ref _forcedTarget, value);
		}

		public QuestSpotTargetReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
