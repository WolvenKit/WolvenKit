using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardPlacementModeStateSbUi_AssetPlacement : CScriptableState
	{
		[Ordinal(1)] [RED("moveStepSize")] 		public CFloat MoveStepSize { get; set;}

		[Ordinal(2)] [RED("rotStepSize")] 		public CFloat RotStepSize { get; set;}

		[Ordinal(3)] [RED("isRotationMode")] 		public CBool IsRotationMode { get; set;}

		[Ordinal(4)] [RED("newPlacement")] 		public SStoryBoardPlacementSettings NewPlacement { get; set;}

		[Ordinal(5)] [RED("asset")] 		public CHandle<CModStoryBoardAsset> Asset { get; set;}

		[Ordinal(6)] [RED("lastFacedAssetId")] 		public CString LastFacedAssetId { get; set;}

		[Ordinal(7)] [RED("theController")] 		public CHandle<CModStoryBoardInteractivePlacement> TheController { get; set;}

		public CModStoryBoardPlacementModeStateSbUi_AssetPlacement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardPlacementModeStateSbUi_AssetPlacement(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}