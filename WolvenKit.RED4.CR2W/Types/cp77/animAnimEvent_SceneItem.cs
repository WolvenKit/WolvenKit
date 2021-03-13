using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_SceneItem : animAnimEvent
	{
		[Ordinal(3)] [RED("boneName")] public CName BoneName { get; set; }

		public animAnimEvent_SceneItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
