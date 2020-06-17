using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneDialogsetInstance : CObject
	{
		[RED("name")] 		public CName Name { get; set;}

		[RED("slots", 2,0)] 		public CArray<CPtr<CStorySceneDialogsetSlot>> Slots { get; set;}

		[RED("placementTag")] 		public TagList PlacementTag { get; set;}

		[RED("snapToTerrain")] 		public CBool SnapToTerrain { get; set;}

		[RED("findSafePlacement")] 		public CBool FindSafePlacement { get; set;}

		[RED("safePlacementRadius")] 		public CFloat SafePlacementRadius { get; set;}

		[RED("areCamerasUsedForBoundsCalculation")] 		public CBool AreCamerasUsedForBoundsCalculation { get; set;}

		[RED("path")] 		public CString Path { get; set;}

		public CStorySceneDialogsetInstance(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneDialogsetInstance(cr2w);

	}
}