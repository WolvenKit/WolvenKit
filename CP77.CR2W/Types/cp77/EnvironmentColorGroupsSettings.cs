using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EnvironmentColorGroupsSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("skyTint")] public curveData<HDRColor> SkyTint { get; set; }
		[Ordinal(3)] [RED("colorGroup", 16)] public CArrayFixedSize<curveData<HDRColor>> ColorGroup { get; set; }

		public EnvironmentColorGroupsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
