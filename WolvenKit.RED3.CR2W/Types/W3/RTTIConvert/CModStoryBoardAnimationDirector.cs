using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardAnimationDirector : CObject
	{
		[Ordinal(1)] [RED("actors", 2,0)] 		public CArray<CHandle<CModStoryBoardActor>> Actors { get; set;}

		[Ordinal(2)] [RED("thePlacementDirector")] 		public CHandle<CModStoryBoardPlacementDirector> ThePlacementDirector { get; set;}

		[Ordinal(3)] [RED("animSequencer")] 		public CHandle<CModSbUiAnimationSequencer> AnimSequencer { get; set;}

		[Ordinal(4)] [RED("idleLoops")] 		public CInt32 IdleLoops { get; set;}

		[Ordinal(5)] [RED("animStateCallback")] 		public CHandle<IModSbUiAnimStateCallback> AnimStateCallback { get; set;}

		public CModStoryBoardAnimationDirector(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}