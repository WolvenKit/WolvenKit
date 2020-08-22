using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventReward : CStorySceneEvent
	{
		[RED("npcTag")] 		public CName NpcTag { get; set;}

		[RED("itemName")] 		public CName ItemName { get; set;}

		[RED("rewardName")] 		public CName RewardName { get; set;}

		[RED("quantity")] 		public CInt32 Quantity { get; set;}

		[RED("dontInformGui")] 		public CBool DontInformGui { get; set;}

		public CStorySceneEventReward(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventReward(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}