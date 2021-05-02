using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardLookAtMode : CModStoryBoardAssetSelectionBasedWorkMode
	{
		[Ordinal(1)] [RED("theLookAtDirector")] 		public CHandle<CModStoryBoardLookAtDirector> TheLookAtDirector { get; set;}

		[Ordinal(2)] [RED("theController")] 		public CHandle<CModStoryBoardInteractiveLookAt> TheController { get; set;}

		public CModStoryBoardLookAtMode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}