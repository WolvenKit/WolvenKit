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
		[Ordinal(1)] [RED("("assets", 2,0)] 		public CArray<CHandle<CModStoryBoardAsset>> Assets { get; set;}

		[Ordinal(2)] [RED("("actors", 2,0)] 		public CArray<CHandle<CModStoryBoardActor>> Actors { get; set;}

		[Ordinal(3)] [RED("("items", 2,0)] 		public CArray<CHandle<CModStoryBoardItem>> Items { get; set;}

		[Ordinal(4)] [RED("("placementDirector")] 		public CHandle<CModStoryBoardPlacementDirector> PlacementDirector { get; set;}

		[Ordinal(5)] [RED("("animDirector")] 		public CHandle<CModStoryBoardAnimationDirector> AnimDirector { get; set;}

		[Ordinal(6)] [RED("("lookAtDirector")] 		public CHandle<CModStoryBoardLookAtDirector> LookAtDirector { get; set;}

		[Ordinal(7)] [RED("("audioDirector")] 		public CHandle<CModStoryBoardAudioDirector> AudioDirector { get; set;}

		[Ordinal(8)] [RED("("lastuid")] 		public CInt32 Lastuid { get; set;}

		[Ordinal(9)] [RED("("selectedAsset")] 		public CHandle<CModStoryBoardAsset> SelectedAsset { get; set;}

		[Ordinal(10)] [RED("("selectedSlot")] 		public CInt32 SelectedSlot { get; set;}

		[Ordinal(11)] [RED("("actorTemplates")] 		public CHandle<CModSbUiEntityTemplateList> ActorTemplates { get; set;}

		[Ordinal(12)] [RED("("itemTemplates")] 		public CHandle<CModSbUiEntityTemplateList> ItemTemplates { get; set;}

		[Ordinal(13)] [RED("("dataLoaded")] 		public CBool DataLoaded { get; set;}

		public CModStoryBoardAssetManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardAssetManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}