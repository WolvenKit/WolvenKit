using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SceneCustomData_Selection : ISceneStorageCustomData
	{
		public SceneCustomData_Selection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
