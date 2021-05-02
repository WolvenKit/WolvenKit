using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskAgony : IBehTreeTask
	{
		[Ordinal(1)] [RED("agonyTime")] 		public CInt32 AgonyTime { get; set;}

		[Ordinal(2)] [RED("syncInstance")] 		public CHandle<CAnimationManualSlotSyncInstance> SyncInstance { get; set;}

		[Ordinal(3)] [RED("disableAgony")] 		public CBool DisableAgony { get; set;}

		[Ordinal(4)] [RED("chance")] 		public CInt32 Chance { get; set;}

		[Ordinal(5)] [RED("forceAgony")] 		public CBool ForceAgony { get; set;}

		public CBehTreeTaskAgony(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}