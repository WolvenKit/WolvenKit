using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardAssetManager : CObject
	{
		[RED("assets", 2,0)] 		public CArray<CHandle<CModStoryBoardAsset>> Assets { get; set;}

		[RED("actors", 2,0)] 		public CArray<CHandle<CModStoryBoardActor>> Actors { get; set;}

		[RED("items", 2,0)] 		public CArray<CHandle<CModStoryBoardItem>> Items { get; set;}

		[RED("placementDirector")] 		public CHandle<CModStoryBoardPlacementDirector> PlacementDirector { get; set;}

		[RED("animDirector")] 		public CHandle<CModStoryBoardAnimationDirector> AnimDirector { get; set;}

		[RED("lookAtDirector")] 		public CHandle<CModStoryBoardLookAtDirector> LookAtDirector { get; set;}

		[RED("audioDirector")] 		public CHandle<CModStoryBoardAudioDirector> AudioDirector { get; set;}

		[RED("lastuid")] 		public CInt32 Lastuid { get; set;}

		[RED("selectedAsset")] 		public CHandle<CModStoryBoardAsset> SelectedAsset { get; set;}

		[RED("selectedSlot")] 		public CInt32 SelectedSlot { get; set;}

		[RED("actorTemplates")] 		public CHandle<CModSbUiEntityTemplateList> ActorTemplates { get; set;}

		[RED("itemTemplates")] 		public CHandle<CModSbUiEntityTemplateList> ItemTemplates { get; set;}

		[RED("dataLoaded")] 		public CBool DataLoaded { get; set;}

		public CModStoryBoardAssetManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardAssetManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}