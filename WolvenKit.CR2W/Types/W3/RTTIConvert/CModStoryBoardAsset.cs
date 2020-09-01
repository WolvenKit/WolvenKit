using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardAsset : CObject
	{
		[Ordinal(1)] [RED("id")] 		public CString Id { get; set;}

		[Ordinal(2)] [RED("shotSettings")] 		public SStoryBoardShotAssetSettings ShotSettings { get; set;}

		[Ordinal(3)] [RED("templatePath")] 		public CString TemplatePath { get; set;}

		[Ordinal(4)] [RED("assetname")] 		public CString Assetname { get; set;}

		[Ordinal(5)] [RED("userSetName")] 		public CBool UserSetName { get; set;}

		[Ordinal(6)] [RED("defaultPlacement")] 		public SStoryBoardPlacementSettings DefaultPlacement { get; set;}

		[Ordinal(7)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(8)] [RED("needsRespawn")] 		public CBool NeedsRespawn { get; set;}

		public CModStoryBoardAsset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardAsset(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}