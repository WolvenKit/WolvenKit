using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIAIBlackboardSerializableID : CVariable
	{
		[Ordinal(0)]  [RED("id")] public gameBlackboardSerializableID Id { get; set; }

		public AIAIBlackboardSerializableID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
