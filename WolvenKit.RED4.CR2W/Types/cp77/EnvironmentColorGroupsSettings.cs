using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EnvironmentColorGroupsSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("skyTint")] public curveData<HDRColor> SkyTint { get; set; }
		[Ordinal(3)] [RED("colorGroup", 16)] public CArrayFixedSize<curveData<HDRColor>> ColorGroup { get; set; }

		public EnvironmentColorGroupsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
