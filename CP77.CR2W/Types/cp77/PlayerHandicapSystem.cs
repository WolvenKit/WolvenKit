using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayerHandicapSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("canDropAmmo")] public CBool CanDropAmmo { get; set; }
		[Ordinal(1)]  [RED("canDropHealingConsumable")] public CBool CanDropHealingConsumable { get; set; }

		public PlayerHandicapSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
