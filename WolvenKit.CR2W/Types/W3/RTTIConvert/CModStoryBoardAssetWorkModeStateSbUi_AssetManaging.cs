using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardAssetWorkModeStateSbUi_AssetManaging : CModStoryBoardWorkModeStateSbUi_WorkModeRootState
	{
		[Ordinal(1)] [RED("("maxActors")] 		public CInt32 MaxActors { get; set;}

		[Ordinal(2)] [RED("("maxItems")] 		public CInt32 MaxItems { get; set;}

		[Ordinal(3)] [RED("("assetManager")] 		public CHandle<CModStoryBoardAssetManager> AssetManager { get; set;}

		public CModStoryBoardAssetWorkModeStateSbUi_AssetManaging(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardAssetWorkModeStateSbUi_AssetManaging(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}