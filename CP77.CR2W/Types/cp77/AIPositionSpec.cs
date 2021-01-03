using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIPositionSpec : CVariable
	{
		[Ordinal(0)]  [RED("entity")] public wCHandle<entEntity> Entity { get; set; }
		[Ordinal(1)]  [RED("worldPosition")] public WorldPosition WorldPosition { get; set; }

		public AIPositionSpec(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
