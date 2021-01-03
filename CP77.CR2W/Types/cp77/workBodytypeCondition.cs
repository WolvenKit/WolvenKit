using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class workBodytypeCondition : workIWorkspotCondition
	{
		[Ordinal(0)]  [RED("rig")] public raRef<animRig> Rig { get; set; }

		public workBodytypeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
