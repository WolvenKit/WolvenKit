using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCDetectingPlayerPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("threshold")] public CFloat Threshold { get; set; }

		public NPCDetectingPlayerPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
