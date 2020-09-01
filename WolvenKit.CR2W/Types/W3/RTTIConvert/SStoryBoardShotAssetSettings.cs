using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStoryBoardShotAssetSettings : CVariable
	{
		[Ordinal(0)] [RED("("assetId")] 		public CString AssetId { get; set;}

		[Ordinal(0)] [RED("("placement")] 		public SStoryBoardPlacementSettings Placement { get; set;}

		[Ordinal(0)] [RED("("pose")] 		public SStoryBoardPoseSettings Pose { get; set;}

		[Ordinal(0)] [RED("("animation")] 		public SStoryBoardAnimationSettings Animation { get; set;}

		[Ordinal(0)] [RED("("mimics")] 		public SStoryBoardAnimationSettings Mimics { get; set;}

		[Ordinal(0)] [RED("("lookAt")] 		public SStoryBoardLookAtSettings LookAt { get; set;}

		[Ordinal(0)] [RED("("audio")] 		public SStoryBoardAudioSettings Audio { get; set;}

		public SStoryBoardShotAssetSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStoryBoardShotAssetSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}