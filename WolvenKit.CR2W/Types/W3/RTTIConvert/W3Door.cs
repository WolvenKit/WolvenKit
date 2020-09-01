using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Door : W3LockableEntity
	{
		[Ordinal(1)] [RED("("rotDir")] 		public CInt32 RotDir { get; set;}

		[Ordinal(2)] [RED("("initiallyOpened")] 		public CBool InitiallyOpened { get; set;}

		[Ordinal(3)] [RED("("factOnPlayerDoorOpen")] 		public CName FactOnPlayerDoorOpen { get; set;}

		[Ordinal(4)] [RED("("isOpened")] 		public CBool IsOpened { get; set;}

		[Ordinal(5)] [RED("("openInteractionComponent")] 		public CHandle<CInteractionComponent> OpenInteractionComponent { get; set;}

		[Ordinal(6)] [RED("("closeInteractionComponent")] 		public CHandle<CInteractionComponent> CloseInteractionComponent { get; set;}

		public W3Door(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Door(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}