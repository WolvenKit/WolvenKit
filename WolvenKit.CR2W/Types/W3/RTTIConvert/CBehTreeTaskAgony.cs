using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskAgony : IBehTreeTask
	{
		[RED("agonyTime")] 		public CInt32 AgonyTime { get; set;}

		[RED("syncInstance")] 		public CHandle<CAnimationManualSlotSyncInstance> SyncInstance { get; set;}

		[RED("disableAgony")] 		public CBool DisableAgony { get; set;}

		[RED("chance")] 		public CInt32 Chance { get; set;}

		[RED("forceAgony")] 		public CBool ForceAgony { get; set;}

		public CBehTreeTaskAgony(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskAgony(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}