using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LightGroupsAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("groupFade", 8)] public CArrayFixedSize<curveData<CFloat>> GroupFade { get; set; }

		public LightGroupsAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
