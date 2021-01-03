using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnGenderMask : CVariable
	{
		[Ordinal(0)]  [RED("mask")] public CUInt8 Mask { get; set; }

		public scnGenderMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
