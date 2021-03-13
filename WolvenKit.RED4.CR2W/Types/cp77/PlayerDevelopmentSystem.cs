using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerDevelopmentSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("playerData")] public CArray<CHandle<PlayerDevelopmentData>> PlayerData { get; set; }
		[Ordinal(1)] [RED("ownerData")] public CArray<CHandle<PlayerDevelopmentData>> OwnerData { get; set; }

		public PlayerDevelopmentSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
