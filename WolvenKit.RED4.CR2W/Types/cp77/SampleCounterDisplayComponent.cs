using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleCounterDisplayComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("targetPersistentID")] public gamePersistentID TargetPersistentID { get; set; }

		public SampleCounterDisplayComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
