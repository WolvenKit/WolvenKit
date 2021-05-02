using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventOpenDoor : CStorySceneEvent
	{
		[Ordinal(1)] [RED("doorTag")] 		public CName DoorTag { get; set;}

		[Ordinal(2)] [RED("instant")] 		public CBool Instant { get; set;}

		[Ordinal(3)] [RED("openClose")] 		public CBool OpenClose { get; set;}

		[Ordinal(4)] [RED("flipDirection")] 		public CBool FlipDirection { get; set;}

		public CStorySceneEventOpenDoor(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventOpenDoor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}