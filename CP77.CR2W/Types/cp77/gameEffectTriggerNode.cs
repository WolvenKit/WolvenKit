using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectTriggerNode : worldAreaShapeNode
	{
		[Ordinal(0)]  [RED("effectDescs")] public CArray<CHandle<gameEffectTriggerEffectDesc>> EffectDescs { get; set; }

		public gameEffectTriggerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
