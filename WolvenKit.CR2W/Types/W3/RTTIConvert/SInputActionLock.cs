using System.IO;
using System.Runtime.Serialization;
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

		public SInputActionLock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SInputActionLock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}