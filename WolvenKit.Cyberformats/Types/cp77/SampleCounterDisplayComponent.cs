using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SampleCounterDisplayComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("targetPersistentID")] public gamePersistentID TargetPersistentID { get; set; }

		public SampleCounterDisplayComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
