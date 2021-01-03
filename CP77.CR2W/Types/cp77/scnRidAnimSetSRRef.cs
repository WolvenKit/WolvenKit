using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnRidAnimSetSRRef : CVariable
	{
		[Ordinal(0)]  [RED("animations")] public CArray<scnSRRefId> Animations { get; set; }

		public scnRidAnimSetSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
