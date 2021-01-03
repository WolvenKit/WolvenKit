using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimationImportInfo : CVariable
	{
		[Ordinal(0)]  [RED("AnimationType")] public CEnum<animAnimationType> AnimationType { get; set; }
		[Ordinal(1)]  [RED("BufferType")] public CEnum<animcompressionBufferTypePreset> BufferType { get; set; }
		[Ordinal(2)]  [RED("CompressionPreset")] public CEnum<animcompressionQualityPreset> CompressionPreset { get; set; }
		[Ordinal(3)]  [RED("FrameratePreset")] public CEnum<animcompressionFrameratePreset> FrameratePreset { get; set; }
		[Ordinal(4)]  [RED("MotionExtractionCompression")] public CEnum<animEMotionExtractionCompressionType> MotionExtractionCompression { get; set; }

		public animAnimationImportInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
