using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Door : W3LockableEntity
	{
		[RED("rotDir")] 		public CInt32 RotDir { get; set;}

		[RED("initiallyOpened")] 		public CBool InitiallyOpened { get; set;}

		[RED("factOnPlayerDoorOpen")] 		public CName FactOnPlayerDoorOpen { get; set;}

		public W3Door(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Door(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}