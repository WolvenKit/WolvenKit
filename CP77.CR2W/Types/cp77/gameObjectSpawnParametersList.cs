using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameObjectSpawnParametersList : gameObjectSpawnParameter
	{
		[Ordinal(0)] [RED("parameterList")] public CArray<CHandle<gameObjectSpawnParameter>> ParameterList { get; set; }

		public gameObjectSpawnParametersList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
