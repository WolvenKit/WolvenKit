using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardCameraModeStateSbUi_InteractiveCamera : CModStoryBoardWorkModeStateSbUi_WorkModeRootState
	{
		[Ordinal(1)] [RED("theCam")] 		public CHandle<CStoryBoardInteractiveCamera> TheCam { get; set;}

		[Ordinal(2)] [RED("fovStepSize")] 		public CFloat FovStepSize { get; set;}

		[Ordinal(3)] [RED("moveStepSize")] 		public CFloat MoveStepSize { get; set;}

		[Ordinal(4)] [RED("rotStepSize")] 		public CFloat RotStepSize { get; set;}

		[Ordinal(5)] [RED("dofStepSize")] 		public CFloat DofStepSize { get; set;}

		[Ordinal(6)] [RED("dofDistStepSize")] 		public CFloat DofDistStepSize { get; set;}

		[Ordinal(7)] [RED("isDofNear")] 		public CBool IsDofNear { get; set;}

		[Ordinal(8)] [RED("isDofMode")] 		public CBool IsDofMode { get; set;}

		[Ordinal(9)] [RED("lastDofCenterActorId")] 		public CString LastDofCenterActorId { get; set;}

		public CModStoryBoardCameraModeStateSbUi_InteractiveCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardCameraModeStateSbUi_InteractiveCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}