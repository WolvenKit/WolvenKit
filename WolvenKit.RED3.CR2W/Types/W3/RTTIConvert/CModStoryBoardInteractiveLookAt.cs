using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardInteractiveLookAt : CEntity
	{
		[Ordinal(1)] [RED("lookAtDirector")] 		public CHandle<CModStoryBoardLookAtDirector> LookAtDirector { get; set;}

		[Ordinal(2)] [RED("actor")] 		public CHandle<CModStoryBoardActor> Actor { get; set;}

		[Ordinal(3)] [RED("lookAt")] 		public SStoryBoardLookAtSettings LookAt { get; set;}

		[Ordinal(4)] [RED("isInteractiveMode")] 		public CBool IsInteractiveMode { get; set;}

		[Ordinal(5)] [RED("stepRotSize")] 		public CFloat StepRotSize { get; set;}

		public CModStoryBoardInteractiveLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardInteractiveLookAt(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}