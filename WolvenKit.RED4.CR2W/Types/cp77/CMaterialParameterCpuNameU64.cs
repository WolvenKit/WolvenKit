using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterCpuNameU64 : CMaterialParameter
	{
		[Ordinal(2)] [RED("name")] public CName Name { get; set; }

		public CMaterialParameterCpuNameU64(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
