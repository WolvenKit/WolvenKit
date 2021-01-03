using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_VectorWsToMs : animAnimNode_VectorValue
	{
		[Ordinal(0)]  [RED("type")] public CEnum<animEVectorWsToMsType> Type { get; set; }
		[Ordinal(1)]  [RED("vectorWs")] public animVectorLink VectorWs { get; set; }

		public animAnimNode_VectorWsToMs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
