using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ApplyDroneProceduralAnimFeatureEvent : redEvent
	{
		[Ordinal(0)]  [RED("feature")] public CHandle<AnimFeature_DroneProcedural> Feature { get; set; }

		public ApplyDroneProceduralAnimFeatureEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
