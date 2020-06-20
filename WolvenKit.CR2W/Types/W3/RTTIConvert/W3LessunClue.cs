using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LessunClue : CFlyingCrittersLairEntityScript
	{
		[RED("pathWaypoints", 2,0)] 		public CArray<CHandle<W3ClueWaypoint>> PathWaypoints { get; set;}

		[RED("factTriggeredAtEnd")] 		public CString FactTriggeredAtEnd { get; set;}

		[RED("loopFlying")] 		public CBool LoopFlying { get; set;}

		[RED("swarmAttractorEntity")] 		public CHandle<CEntityTemplate> SwarmAttractorEntity { get; set;}

		public W3LessunClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LessunClue(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}