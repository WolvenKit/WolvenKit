using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CMeshMaterialEntry : CVariable
	{
		[Ordinal(0)]  [RED("index")] public CUInt16 Index { get; set; }
		[Ordinal(1)]  [RED("isLocalInstance")] public CBool IsLocalInstance { get; set; }
		[Ordinal(2)]  [RED("name")] public CName Name { get; set; }

		public CMeshMaterialEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
