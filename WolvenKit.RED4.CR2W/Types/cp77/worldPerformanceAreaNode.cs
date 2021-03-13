using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPerformanceAreaNode : worldTriggerAreaNode
	{
		[Ordinal(7)] [RED("qualitySettingsArray")] public CArray<worldQualitySetting> QualitySettingsArray { get; set; }
		[Ordinal(8)] [RED("disableCrowdUniqueName")] public CName DisableCrowdUniqueName { get; set; }
		[Ordinal(9)] [RED("globalStreamingDistanceScale")] public CFloat GlobalStreamingDistanceScale { get; set; }

		public worldPerformanceAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
