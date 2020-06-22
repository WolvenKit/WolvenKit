using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardLookAtModeStateSbUi_ActorLookAt : CScriptableState
	{
		[RED("rotateStepSize")] 		public CFloat RotateStepSize { get; set;}

		[RED("newLookAt")] 		public SStoryBoardLookAtSettings NewLookAt { get; set;}

		[RED("actor")] 		public CHandle<CModStoryBoardActor> Actor { get; set;}

		[RED("lastLookedAtAssetId")] 		public CString LastLookedAtAssetId { get; set;}

		[RED("theController")] 		public CHandle<CModStoryBoardInteractiveLookAt> TheController { get; set;}

		public CModStoryBoardLookAtModeStateSbUi_ActorLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardLookAtModeStateSbUi_ActorLookAt(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}