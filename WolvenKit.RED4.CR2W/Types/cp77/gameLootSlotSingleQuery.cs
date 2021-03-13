using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootSlotSingleQuery : gameLootSlot
	{
		[Ordinal(53)] [RED("queryTDBID")] public TweakDBID QueryTDBID { get; set; }

		public gameLootSlotSingleQuery(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
