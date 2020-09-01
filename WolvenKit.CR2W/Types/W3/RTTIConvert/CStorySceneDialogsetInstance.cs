using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneDialogsetInstance : CObject
	{
		[Ordinal(0)] [RED("("name")] 		public CName Name { get; set;}

		[Ordinal(0)] [RED("("slots", 2,0)] 		public CArray<CPtr<CStorySceneDialogsetSlot>> Slots { get; set;}

		[Ordinal(0)] [RED("("placementTag")] 		public TagList PlacementTag { get; set;}

		[Ordinal(0)] [RED("("snapToTerrain")] 		public CBool SnapToTerrain { get; set;}

		[Ordinal(0)] [RED("("findSafePlacement")] 		public CBool FindSafePlacement { get; set;}

		[Ordinal(0)] [RED("("safePlacementRadius")] 		public CFloat SafePlacementRadius { get; set;}

		[Ordinal(0)] [RED("("areCamerasUsedForBoundsCalculation")] 		public CBool AreCamerasUsedForBoundsCalculation { get; set;}

		[Ordinal(0)] [RED("("path")] 		public CString Path { get; set;}

		public CStorySceneDialogsetInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneDialogsetInstance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}