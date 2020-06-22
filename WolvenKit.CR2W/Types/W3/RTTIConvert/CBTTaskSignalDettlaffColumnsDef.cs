using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSignalDettlaffColumnsDef : IBehTreeTaskDefinition
	{
		[RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[RED("summonerComponent")] 		public CHandle<W3SummonerComponent> SummonerComponent { get; set;}

		[RED("summonsArray", 2,0)] 		public CArray<CHandle<CEntity>> SummonsArray { get; set;}

		[RED("columnEntity")] 		public CHandle<CDettlaffColumn> ColumnEntity { get; set;}

		[RED("shouldComplete")] 		public CBool ShouldComplete { get; set;}

		[RED("startPumping")] 		public CBool StartPumping { get; set;}

		[RED("stopPumping")] 		public CBool StopPumping { get; set;}

		public CBTTaskSignalDettlaffColumnsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSignalDettlaffColumnsDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}