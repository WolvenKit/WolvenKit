using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedataLightPreset : CVariable
	{
		[Ordinal(0)] [RED("lightSourcesName")] public CName LightSourcesName { get; set; }
		[Ordinal(1)] [RED("preset")] public TweakDBID Preset { get; set; }

		public gamedataLightPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
