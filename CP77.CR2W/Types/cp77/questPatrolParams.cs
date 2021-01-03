using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questPatrolParams : questAICommandParams
	{
		[Ordinal(0)]  [RED("pathParams")] public CHandle<AIPatrolPathParameters> PathParams { get; set; }
		[Ordinal(1)]  [RED("repeatCommandOnInterrupt")] public CBool RepeatCommandOnInterrupt { get; set; }

		public questPatrolParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
