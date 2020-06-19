using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStoryBoardShotAssetSettings : CVariable
	{
		[RED("assetId")] 		public CString AssetId { get; set;}

		[RED("placement")] 		public SStoryBoardPlacementSettings Placement { get; set;}

		[RED("pose")] 		public SStoryBoardPoseSettings Pose { get; set;}

		[RED("animation")] 		public SStoryBoardAnimationSettings Animation { get; set;}

		[RED("mimics")] 		public SStoryBoardAnimationSettings Mimics { get; set;}

		[RED("lookAt")] 		public SStoryBoardLookAtSettings LookAt { get; set;}

		[RED("audio")] 		public SStoryBoardAudioSettings Audio { get; set;}

		public SStoryBoardShotAssetSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStoryBoardShotAssetSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}