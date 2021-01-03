using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SCyberware : CVariable
	{
		[Ordinal(0)]  [RED("cyberWareTier")] public CInt32 CyberWareTier { get; set; }
		[Ordinal(1)]  [RED("cyberwareName")] public CString CyberwareName { get; set; }
		[Ordinal(2)]  [RED("loc_desc_key")] public CString Loc_desc_key { get; set; }
		[Ordinal(3)]  [RED("loc_name_key")] public CString Loc_name_key { get; set; }

		public SCyberware(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
