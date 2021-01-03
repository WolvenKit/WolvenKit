using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ChestPress : InteractiveDevice
	{
		[Ordinal(0)]  [RED("animFeatureData")] public CHandle<AnimFeature_ChestPress> AnimFeatureData { get; set; }
		[Ordinal(1)]  [RED("animFeatureDataName")] public CName AnimFeatureDataName { get; set; }

		public ChestPress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
