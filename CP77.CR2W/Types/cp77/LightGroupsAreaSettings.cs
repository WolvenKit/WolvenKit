using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LightGroupsAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("groupFade")] public [8]curveData<CFloat> GroupFade { get; set; }

		public LightGroupsAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
