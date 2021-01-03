using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterHairParameters : CMaterialParameter
	{
		[Ordinal(0)]  [RED("hairProfile")] public rRef<CHairProfile> HairProfile { get; set; }

		public CMaterialParameterHairParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
