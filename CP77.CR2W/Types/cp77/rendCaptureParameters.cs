using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendCaptureParameters : CVariable
	{
		[Ordinal(0)]  [RED("audioRecordingMode")] public CBool AudioRecordingMode { get; set; }
		[Ordinal(1)]  [RED("captureContextType")] public CEnum<rendCaptureContextType> CaptureContextType { get; set; }
		[Ordinal(2)]  [RED("customResolution")] public Point CustomResolution { get; set; }
		[Ordinal(3)]  [RED("emmModes")] public CArray<CEnum<EEnvManagerModifier>> EmmModes { get; set; }
		[Ordinal(4)]  [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(5)]  [RED("fovMultiplier")] public CFloat FovMultiplier { get; set; }
		[Ordinal(6)]  [RED("initialFrameNumber")] public CUInt32 InitialFrameNumber { get; set; }
		[Ordinal(7)]  [RED("mode")] public CEnum<rendScreenshotMode> Mode { get; set; }
		[Ordinal(8)]  [RED("outputDirectoryIndex")] public CUInt32 OutputDirectoryIndex { get; set; }
		[Ordinal(9)]  [RED("outputDirectoryName")] public CString OutputDirectoryName { get; set; }
		[Ordinal(10)]  [RED("outputDirectoryNameSuffix")] public CString OutputDirectoryNameSuffix { get; set; }
		[Ordinal(11)]  [RED("outputPath")] public AbsolutePathSerializable OutputPath { get; set; }
		[Ordinal(12)]  [RED("recordingFPS")] public CUInt32 RecordingFPS { get; set; }
		[Ordinal(13)]  [RED("resolutionMultiplier")] public CEnum<rendResolutionMultiplier> ResolutionMultiplier { get; set; }
		[Ordinal(14)]  [RED("saveFormat")] public CEnum<ESaveFormat> SaveFormat { get; set; }
		[Ordinal(15)]  [RED("videoRecordingMode")] public CBool VideoRecordingMode { get; set; }

		public rendCaptureParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
