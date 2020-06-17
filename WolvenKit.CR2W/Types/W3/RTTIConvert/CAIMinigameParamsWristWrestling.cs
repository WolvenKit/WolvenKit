using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMinigameParamsWristWrestling : CObject
	{
		[RED("hotSpotMinWidth")] 		public CInt32 HotSpotMinWidth { get; set;}

		[RED("hotSpotMaxWidth")] 		public CInt32 HotSpotMaxWidth { get; set;}

		[RED("gameDifficulty")] 		public EAIMinigameDifficulty GameDifficulty { get; set;}

		public CAIMinigameParamsWristWrestling(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIMinigameParamsWristWrestling(cr2w);

	}
}