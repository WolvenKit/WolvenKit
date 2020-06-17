using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventEquipItem : CStorySceneEvent
	{
		[RED("leftItem")] 		public CName LeftItem { get; set;}

		[RED("rightItem")] 		public CName RightItem { get; set;}

		[RED("actor")] 		public CName Actor { get; set;}

		[RED("ignoreItemsWithTag")] 		public CName IgnoreItemsWithTag { get; set;}

		[RED("internalMode")] 		public ESceneItemEventMode InternalMode { get; set;}

		[RED("instant")] 		public CBool Instant { get; set;}

		public CStorySceneEventEquipItem(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventEquipItem(cr2w);

	}
}