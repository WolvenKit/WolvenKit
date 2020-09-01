using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFindActorsByTagDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(0)] [RED("("tag")] 		public CName Tag { get; set;}

		[Ordinal(0)] [RED("("foundActorsArray", 2,0)] 		public CArray<CHandle<CActor>> FoundActorsArray { get; set;}

		[Ordinal(0)] [RED("("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[Ordinal(0)] [RED("("numberOfActors")] 		public CInt32 NumberOfActors { get; set;}

		[Ordinal(0)] [RED("("range")] 		public CFloat Range { get; set;}

		[Ordinal(0)] [RED("("onlyLiveActors")] 		public CBool OnlyLiveActors { get; set;}

		[Ordinal(0)] [RED("("oppNo")] 		public CInt32 OppNo { get; set;}

		[Ordinal(0)] [RED("("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		public CBTTaskFindActorsByTagDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFindActorsByTagDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}