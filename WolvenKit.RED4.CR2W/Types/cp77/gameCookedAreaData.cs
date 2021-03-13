using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCookedAreaData : CVariable
	{
		[Ordinal(0)] [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(1)] [RED("position")] public Vector3 Position { get; set; }
		[Ordinal(2)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(3)] [RED("volume")] public CHandle<gamemappinsIMappinVolume> Volume { get; set; }

		public gameCookedAreaData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
