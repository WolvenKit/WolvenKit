using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimSetCollection : CVariable
	{
		[Ordinal(0)] [RED("animSets")] public CArray<raRef<animAnimSet>> AnimSets { get; set; }
		[Ordinal(1)] [RED("overrideAnimSets")] public CArray<animOverrideAnimSetRef> OverrideAnimSets { get; set; }
		[Ordinal(2)] [RED("animWrapperVariables")] public CArray<animAnimWrapperVariableDescription> AnimWrapperVariables { get; set; }

		public animAnimSetCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
