using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCompiledSmartObjectNode : CVariable
	{
		[Ordinal(0)]  [RED("worldTransform")] public WorldTransform WorldTransform { get; set; }
		[Ordinal(1)]  [RED("compiledData")] public CHandle<gameCompiledSmartObjectData> CompiledData { get; set; }

		public gameCompiledSmartObjectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
