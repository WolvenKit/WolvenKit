using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectTriggerNode : worldAreaShapeNode
	{
		[Ordinal(0)]  [RED("effectDescs")] public CArray<CHandle<gameEffectTriggerEffectDesc>> EffectDescs { get; set; }

		public gameEffectTriggerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
