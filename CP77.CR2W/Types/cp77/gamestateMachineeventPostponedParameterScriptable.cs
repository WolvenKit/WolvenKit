using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventPostponedParameterScriptable : gamestateMachineeventPostponedParameterBase
	{
		[Ordinal(2)] [RED("value")] public CHandle<IScriptable> Value { get; set; }

		public gamestateMachineeventPostponedParameterScriptable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
