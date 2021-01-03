using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AgentDistanceToTarget : CVariable
	{
		[Ordinal(0)]  [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(1)]  [RED("index")] public CInt32 Index { get; set; }

		public AgentDistanceToTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
