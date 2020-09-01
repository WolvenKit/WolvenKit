using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SyncAnimationManager : CObject
	{
		[Ordinal(1)] [RED("("syncInstances", 2,0)] 		public CArray<CHandle<CAnimationManualSlotSyncInstance>> SyncInstances { get; set;}

		[Ordinal(2)] [RED("("masterEntity")] 		public CHandle<CGameplayEntity> MasterEntity { get; set;}

		[Ordinal(3)] [RED("("slaveEntity")] 		public CHandle<CGameplayEntity> SlaveEntity { get; set;}

		[Ordinal(4)] [RED("("syncActionName")] 		public CName SyncActionName { get; set;}

		[Ordinal(5)] [RED("("dlcFinishersLeftSide", 2,0)] 		public CArray<CHandle<CR4FinisherDLC>> DlcFinishersLeftSide { get; set;}

		[Ordinal(6)] [RED("("dlcFinishersRightSide", 2,0)] 		public CArray<CHandle<CR4FinisherDLC>> DlcFinishersRightSide { get; set;}

		[Ordinal(7)] [RED("("cameraAnimName")] 		public CName CameraAnimName { get; set;}

		public W3SyncAnimationManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SyncAnimationManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}