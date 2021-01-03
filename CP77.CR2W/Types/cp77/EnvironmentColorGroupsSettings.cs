using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EnvironmentColorGroupsSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("colorGroup", 16)] public CArrayFixedSize<curveData<HDRColor>> ColorGroup { get; set; }
		[Ordinal(1)]  [RED("skyTint")] public curveData<HDRColor> SkyTint { get; set; }

		public EnvironmentColorGroupsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
