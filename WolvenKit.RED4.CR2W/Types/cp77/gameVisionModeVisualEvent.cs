using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeVisualEvent : redEvent
	{
		[Ordinal(0)] [RED("group")] public TweakDBID Group { get; set; }
		[Ordinal(1)] [RED("changedModule")] public CName ChangedModule { get; set; }
		[Ordinal(2)] [RED("activated")] public CBool Activated { get; set; }
		[Ordinal(3)] [RED("meshComponentName")] public CName MeshComponentName { get; set; }
		[Ordinal(4)] [RED("type")] public CEnum<gameVisionModeType> Type { get; set; }

		public gameVisionModeVisualEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
