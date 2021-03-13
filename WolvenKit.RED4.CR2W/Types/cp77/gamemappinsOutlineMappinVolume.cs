using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsOutlineMappinVolume : gamemappinsIMappinVolume
	{
		[Ordinal(0)] [RED("height")] public CFloat Height { get; set; }
		[Ordinal(1)] [RED("outlinePoints")] public CArray<Vector2> OutlinePoints { get; set; }

		public gamemappinsOutlineMappinVolume(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
