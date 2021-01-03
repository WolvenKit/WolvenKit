using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameBodyTypeAnimationDefinition : CVariable
	{
		[Ordinal(0)]  [RED("animsets")] public CArray<raRef<animAnimSet>> Animsets { get; set; }
		[Ordinal(1)]  [RED("overrides")] public CArray<gameAnimationOverrideDefinition> Overrides { get; set; }
		[Ordinal(2)]  [RED("rig")] public raRef<animRig> Rig { get; set; }

		public gameBodyTypeAnimationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
