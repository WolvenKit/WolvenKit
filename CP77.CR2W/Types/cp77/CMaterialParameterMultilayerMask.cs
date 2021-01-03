using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterMultilayerMask : CMaterialParameter
	{
		[Ordinal(0)]  [RED("mask")] public rRef<Multilayer_Mask> Mask { get; set; }

		public CMaterialParameterMultilayerMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
