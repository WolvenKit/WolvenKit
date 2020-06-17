using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SInputActionLock : CVariable
	{
		[RED("sourceName")] 		public CName SourceName { get; set;}

		[RED("removedOnSpawn")] 		public CBool RemovedOnSpawn { get; set;}

		[RED("isFromQuest")] 		public CBool IsFromQuest { get; set;}

		[RED("isFromPlace")] 		public CBool IsFromPlace { get; set;}

		public SInputActionLock(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SInputActionLock(cr2w);

	}
}