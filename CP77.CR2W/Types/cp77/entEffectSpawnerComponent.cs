using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entEffectSpawnerComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("effectDescs")] public CArray<CHandle<entEffectDesc>> EffectDescs { get; set; }

		public entEffectSpawnerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
