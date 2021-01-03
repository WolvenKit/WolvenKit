using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsApperanceMaterial : CVariable
	{
		[Ordinal(0)]  [RED("apperanceName")] public CName ApperanceName { get; set; }
		[Ordinal(1)]  [RED("material")] public CName Material { get; set; }
		[Ordinal(2)]  [RED("materialFrom")] public CName MaterialFrom { get; set; }

		public physicsApperanceMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
