using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimationSystemForcedVisibilityManager : gameScriptableSystem
	{
		[Ordinal(0)] [RED("entities")] public CArray<CHandle<AnimationSystemForcedVisibilityEntityData>> Entities { get; set; }

		public AnimationSystemForcedVisibilityManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
