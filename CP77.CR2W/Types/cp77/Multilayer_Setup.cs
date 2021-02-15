using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Multilayer_Setup : CResource
	{
		[Ordinal(1)] [RED("layers")] public CArray<Multilayer_Layer> Layers { get; set; }
		[Ordinal(2)] [RED("ratio")] public CFloat Ratio { get; set; }
		[Ordinal(3)] [RED("useNormal")] public CBool UseNormal { get; set; }

		public Multilayer_Setup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
