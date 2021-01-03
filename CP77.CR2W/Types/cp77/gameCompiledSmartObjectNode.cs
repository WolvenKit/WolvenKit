using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameCompiledSmartObjectNode : CVariable
	{
		[Ordinal(0)]  [RED("compiledData")] public CHandle<gameCompiledSmartObjectData> CompiledData { get; set; }
		[Ordinal(1)]  [RED("worldTransform")] public WorldTransform WorldTransform { get; set; }

		public gameCompiledSmartObjectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
