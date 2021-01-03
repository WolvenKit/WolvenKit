using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animLookAtPartInfo : CVariable
	{
		[Ordinal(0)]  [RED("defaultPositionBoneName")] public CName DefaultPositionBoneName { get; set; }
		[Ordinal(1)]  [RED("partName")] public CName PartName { get; set; }

		public animLookAtPartInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
