using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AddActiveStimuli : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("stimType")] public CEnum<gamedataStimType> StimType { get; set; }
		[Ordinal(1)] [RED("lifetime")] public CFloat Lifetime { get; set; }

		public AddActiveStimuli(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
