using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NPCDetectingPlayerPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("threshold")] public CFloat Threshold { get; set; }

		public NPCDetectingPlayerPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
