using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStoryBoardAssetsStateData : CVariable
	{
		[Ordinal(1)] [RED("lastuid")] 		public CInt32 Lastuid { get; set;}

		[Ordinal(2)] [RED("actorData", 2,0)] 		public CArray<SStoryBoardActorStateData> ActorData { get; set;}

		[Ordinal(3)] [RED("itemData", 2,0)] 		public CArray<SStoryBoardItemStateData> ItemData { get; set;}

		public SStoryBoardAssetsStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStoryBoardAssetsStateData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}