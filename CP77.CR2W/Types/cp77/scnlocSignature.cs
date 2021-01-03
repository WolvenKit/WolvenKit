using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnlocSignature : CVariable
	{
		[Ordinal(0)]  [RED("val")] public CUInt64 Val { get; set; }

		public scnlocSignature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
