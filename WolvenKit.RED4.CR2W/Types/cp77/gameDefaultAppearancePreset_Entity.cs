using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDefaultAppearancePreset_Entity : ISerializable
	{
		[Ordinal(0)] [RED("entityPathHash")] public CUInt64 EntityPathHash { get; set; }
		[Ordinal(1)] [RED("debugEntityPath")] public CName DebugEntityPath { get; set; }
		[Ordinal(2)] [RED("defaultAppearanceName")] public CName DefaultAppearanceName { get; set; }

		public gameDefaultAppearancePreset_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
