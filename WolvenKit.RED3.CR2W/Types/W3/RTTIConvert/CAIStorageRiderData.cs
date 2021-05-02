using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIStorageRiderData : IScriptable
	{
		[Ordinal(1)] [RED("sharedParams")] 		public CHandle<CHorseRiderSharedParams> SharedParams { get; set;}

		[Ordinal(2)] [RED("ridingManagerMountError")] 		public CBool RidingManagerMountError { get; set;}

		[Ordinal(3)] [RED("ridingManagerCurrentTask")] 		public CEnum<ERidingManagerTask> RidingManagerCurrentTask { get; set;}

		[Ordinal(4)] [RED("horseScriptedActionTree")] 		public CHandle<IAIActionTree> HorseScriptedActionTree { get; set;}

		[Ordinal(5)] [RED("ridingManagerDismountType")] 		public CEnum<EDismountType> RidingManagerDismountType { get; set;}

		[Ordinal(6)] [RED("ridingManagerInstantMount")] 		public CBool RidingManagerInstantMount { get; set;}

		public CAIStorageRiderData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}