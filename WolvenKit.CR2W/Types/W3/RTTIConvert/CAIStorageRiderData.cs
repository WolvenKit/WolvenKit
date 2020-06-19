using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIStorageRiderData : IScriptable
	{
		[RED("sharedParams")] 		public CHandle<CHorseRiderSharedParams> SharedParams { get; set;}

		[RED("ridingManagerMountError")] 		public CBool RidingManagerMountError { get; set;}

		[RED("ridingManagerCurrentTask")] 		public CEnum<ERidingManagerTask> RidingManagerCurrentTask { get; set;}

		[RED("horseScriptedActionTree")] 		public CHandle<IAIActionTree> HorseScriptedActionTree { get; set;}

		[RED("ridingManagerDismountType")] 		public CEnum<EDismountType> RidingManagerDismountType { get; set;}

		[RED("ridingManagerInstantMount")] 		public CBool RidingManagerInstantMount { get; set;}

		public CAIStorageRiderData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIStorageRiderData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}