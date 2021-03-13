using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AutocraftSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("active")] public CBool Active { get; set; }
		[Ordinal(1)] [RED("cycleDuration")] public CFloat CycleDuration { get; set; }
		[Ordinal(2)] [RED("currentDelayID")] public gameDelayID CurrentDelayID { get; set; }
		[Ordinal(3)] [RED("itemsUsed")] public CArray<gameItemID> ItemsUsed { get; set; }

		public AutocraftSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
