using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardAsset : CObject
	{
		[RED("id")] 		public CString Id { get; set;}

		[RED("shotSettings")] 		public SStoryBoardShotAssetSettings ShotSettings { get; set;}

		[RED("templatePath")] 		public CString TemplatePath { get; set;}

		[RED("assetname")] 		public CString Assetname { get; set;}

		[RED("userSetName")] 		public CBool UserSetName { get; set;}

		[RED("defaultPlacement")] 		public SStoryBoardPlacementSettings DefaultPlacement { get; set;}

		[RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[RED("needsRespawn")] 		public CBool NeedsRespawn { get; set;}

		public CModStoryBoardAsset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardAsset(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}