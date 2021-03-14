using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardLookAtModeStateSbUi_ActorLookAt : CScriptableState
	{
		[Ordinal(1)] [RED("rotateStepSize")] 		public CFloat RotateStepSize { get; set;}

		[Ordinal(2)] [RED("newLookAt")] 		public SStoryBoardLookAtSettings NewLookAt { get; set;}

		[Ordinal(3)] [RED("actor")] 		public CHandle<CModStoryBoardActor> Actor { get; set;}

		[Ordinal(4)] [RED("lastLookedAtAssetId")] 		public CString LastLookedAtAssetId { get; set;}

		[Ordinal(5)] [RED("theController")] 		public CHandle<CModStoryBoardInteractiveLookAt> TheController { get; set;}

		public CModStoryBoardLookAtModeStateSbUi_ActorLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardLookAtModeStateSbUi_ActorLookAt(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}