using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventEquipItem : CStorySceneEvent
	{
		[Ordinal(1)] [RED("leftItem")] 		public CName LeftItem { get; set;}

		[Ordinal(2)] [RED("rightItem")] 		public CName RightItem { get; set;}

		[Ordinal(3)] [RED("actor")] 		public CName Actor { get; set;}

		[Ordinal(4)] [RED("ignoreItemsWithTag")] 		public CName IgnoreItemsWithTag { get; set;}

		[Ordinal(5)] [RED("internalMode")] 		public CEnum<ESceneItemEventMode> InternalMode { get; set;}

		[Ordinal(6)] [RED("instant")] 		public CBool Instant { get; set;}

		public CStorySceneEventEquipItem(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}