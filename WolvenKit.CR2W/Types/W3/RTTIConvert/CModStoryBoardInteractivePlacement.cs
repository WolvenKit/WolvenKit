using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardInteractivePlacement : CEntity
	{
		[RED("placement")] 		public SStoryBoardPlacementSettings Placement { get; set;}

		[RED("asset")] 		public CHandle<CModStoryBoardAsset> Asset { get; set;}

		[RED("isInteractiveMode")] 		public CBool IsInteractiveMode { get; set;}

		[RED("snapToGround")] 		public CBool SnapToGround { get; set;}

		[RED("isRotationMode")] 		public CBool IsRotationMode { get; set;}

		[RED("stepMoveSize")] 		public CFloat StepMoveSize { get; set;}

		[RED("stepRotSize")] 		public CFloat StepRotSize { get; set;}

		[RED("camHeading")] 		public CFloat CamHeading { get; set;}

		[RED("theWorld")] 		public CHandle<CWorld> TheWorld { get; set;}

		public CModStoryBoardInteractivePlacement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardInteractivePlacement(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}