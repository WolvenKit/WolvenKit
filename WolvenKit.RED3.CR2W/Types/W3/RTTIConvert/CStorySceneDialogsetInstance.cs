using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneDialogsetInstance : CObject
	{
		[Ordinal(1)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(2)] [RED("slots", 2,0)] 		public CArray<CPtr<CStorySceneDialogsetSlot>> Slots { get; set;}

		[Ordinal(3)] [RED("placementTag")] 		public TagList PlacementTag { get; set;}

		[Ordinal(4)] [RED("snapToTerrain")] 		public CBool SnapToTerrain { get; set;}

		[Ordinal(5)] [RED("findSafePlacement")] 		public CBool FindSafePlacement { get; set;}

		[Ordinal(6)] [RED("safePlacementRadius")] 		public CFloat SafePlacementRadius { get; set;}

		[Ordinal(7)] [RED("areCamerasUsedForBoundsCalculation")] 		public CBool AreCamerasUsedForBoundsCalculation { get; set;}

		[Ordinal(8)] [RED("path")] 		public CString Path { get; set;}

		public CStorySceneDialogsetInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneDialogsetInstance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}