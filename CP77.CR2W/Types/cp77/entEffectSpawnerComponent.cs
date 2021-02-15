using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entEffectSpawnerComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("effectDescs")] public CArray<CHandle<entEffectDesc>> EffectDescs { get; set; }

		public entEffectSpawnerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
