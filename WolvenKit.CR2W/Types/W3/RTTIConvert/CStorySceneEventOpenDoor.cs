using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventOpenDoor : CStorySceneEvent
	{
		[RED("doorTag")] 		public CName DoorTag { get; set;}

		[RED("instant")] 		public CBool Instant { get; set;}

		[RED("openClose")] 		public CBool OpenClose { get; set;}

		[RED("flipDirection")] 		public CBool FlipDirection { get; set;}

		public CStorySceneEventOpenDoor(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventOpenDoor(cr2w);

	}
}