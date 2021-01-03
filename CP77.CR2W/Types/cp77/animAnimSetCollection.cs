using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimSetCollection : CVariable
	{
		[Ordinal(0)]  [RED("animSets")] public CArray<raRef<animAnimSet>> AnimSets { get; set; }
		[Ordinal(1)]  [RED("animWrapperVariables")] public CArray<animAnimWrapperVariableDescription> AnimWrapperVariables { get; set; }
		[Ordinal(2)]  [RED("overrideAnimSets")] public CArray<animOverrideAnimSetRef> OverrideAnimSets { get; set; }

		public animAnimSetCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
