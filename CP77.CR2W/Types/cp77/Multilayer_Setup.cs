using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Multilayer_Setup : CResource
	{
		[Ordinal(0)]  [RED("layers")] public CArray<Multilayer_Layer> Layers { get; set; }
		[Ordinal(1)]  [RED("ratio")] public CFloat Ratio { get; set; }
		[Ordinal(2)]  [RED("useNormal")] public CBool UseNormal { get; set; }

		public Multilayer_Setup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
