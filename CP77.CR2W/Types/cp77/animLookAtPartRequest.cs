using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animLookAtPartRequest : CVariable
	{
		[Ordinal(0)]  [RED("mode")] public CInt32 Mode { get; set; }
		[Ordinal(1)]  [RED("partName")] public CName PartName { get; set; }
		[Ordinal(2)]  [RED("suppress")] public CFloat Suppress { get; set; }
		[Ordinal(3)]  [RED("weight")] public CFloat Weight { get; set; }

		public animLookAtPartRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
