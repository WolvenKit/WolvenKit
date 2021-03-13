using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidTag : CVariable
	{
		[Ordinal(0)] [RED("signature")] public CName Signature { get; set; }
		[Ordinal(1)] [RED("serialNumber")] public scnRidSerialNumber SerialNumber { get; set; }

		public scnRidTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
