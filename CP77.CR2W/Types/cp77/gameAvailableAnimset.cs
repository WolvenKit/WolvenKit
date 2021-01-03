using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameAvailableAnimset : CVariable
	{
		[Ordinal(0)]  [RED("hash")] public CUInt64 Hash { get; set; }
		[Ordinal(1)]  [RED("resourcePath")] public CString ResourcePath { get; set; }

		public gameAvailableAnimset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
