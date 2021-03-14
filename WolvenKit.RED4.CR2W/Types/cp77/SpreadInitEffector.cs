using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpreadInitEffector : gameEffector
	{
		[Ordinal(0)] [RED("objectActionRecord")] public wCHandle<gamedataObjectAction_Record> ObjectActionRecord { get; set; }
		[Ordinal(1)] [RED("effectorRecord")] public CHandle<gamedataSpreadInitEffector_Record> EffectorRecord { get; set; }
		[Ordinal(2)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }

		public SpreadInitEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
