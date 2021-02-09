using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerHandicapSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("canDropHealingConsumable")] public CBool CanDropHealingConsumable { get; set; }
		[Ordinal(1)]  [RED("canDropAmmo")] public CBool CanDropAmmo { get; set; }

		public PlayerHandicapSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
