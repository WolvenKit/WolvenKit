using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerDevelopmentSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("ownerData")] public CArray<CHandle<PlayerDevelopmentData>> OwnerData { get; set; }
		[Ordinal(1)]  [RED("playerData")] public CArray<CHandle<PlayerDevelopmentData>> PlayerData { get; set; }

		public PlayerDevelopmentSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
