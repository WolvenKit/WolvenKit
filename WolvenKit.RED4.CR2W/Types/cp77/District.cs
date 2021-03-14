using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class District : IScriptable
	{
		[Ordinal(0)] [RED("districtID")] public TweakDBID DistrictID { get; set; }
		[Ordinal(1)] [RED("presetID")] public TweakDBID PresetID { get; set; }

		public District(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
