using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceCensorshipEntry : CVariable
	{
		[Ordinal(0)] [RED("Original")] public CName Original { get; set; }
		[Ordinal(1)] [RED("Censored")] public CName Censored { get; set; }
		[Ordinal(2)] [RED("CensorFlags")] public CUInt32 CensorFlags { get; set; }

		public appearanceCensorshipEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
