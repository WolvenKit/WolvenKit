using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Door : W3LockableEntity
	{
		[Ordinal(1)] [RED("rotDir")] 		public CInt32 RotDir { get; set;}

		[Ordinal(2)] [RED("initiallyOpened")] 		public CBool InitiallyOpened { get; set;}

		[Ordinal(3)] [RED("factOnPlayerDoorOpen")] 		public CName FactOnPlayerDoorOpen { get; set;}

		[Ordinal(4)] [RED("isOpened")] 		public CBool IsOpened { get; set;}

		[Ordinal(5)] [RED("openInteractionComponent")] 		public CHandle<CInteractionComponent> OpenInteractionComponent { get; set;}

		[Ordinal(6)] [RED("closeInteractionComponent")] 		public CHandle<CInteractionComponent> CloseInteractionComponent { get; set;}

		public W3Door(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}