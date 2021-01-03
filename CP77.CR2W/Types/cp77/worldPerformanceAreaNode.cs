using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldPerformanceAreaNode : worldTriggerAreaNode
	{
		[Ordinal(0)]  [RED("disableCrowdUniqueName")] public CName DisableCrowdUniqueName { get; set; }
		[Ordinal(1)]  [RED("globalStreamingDistanceScale")] public CFloat GlobalStreamingDistanceScale { get; set; }
		[Ordinal(2)]  [RED("qualitySettingsArray")] public CArray<worldQualitySetting> QualitySettingsArray { get; set; }

		public worldPerformanceAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
