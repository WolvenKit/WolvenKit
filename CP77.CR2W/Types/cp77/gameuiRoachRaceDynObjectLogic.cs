using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceDynObjectLogic : gameuiSideScrollerMiniGameDynObjectLogic
	{
		[Ordinal(0)]  [RED("availableY")] public CArray<CFloat> AvailableY { get; set; }
		[Ordinal(1)]  [RED("extraSpeed")] public CFloat ExtraSpeed { get; set; }
		[Ordinal(2)]  [RED("maxSpawnY")] public CFloat MaxSpawnY { get; set; }
		[Ordinal(3)]  [RED("minSpawnY")] public CFloat MinSpawnY { get; set; }

		public gameuiRoachRaceDynObjectLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
