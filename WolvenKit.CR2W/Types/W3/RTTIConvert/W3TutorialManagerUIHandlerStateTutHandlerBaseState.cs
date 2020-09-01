using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateTutHandlerBaseState : CScriptableState
	{
		[Ordinal(1)] [RED("defaultTutorialMessage")] 		public STutorialMessage DefaultTutorialMessage { get; set;}

		[Ordinal(2)] [RED("currentlyShownHint")] 		public CName CurrentlyShownHint { get; set;}

		[Ordinal(3)] [RED("POS_INVENTORY_X")] 		public CFloat POS_INVENTORY_X { get; set;}

		[Ordinal(4)] [RED("POS_INVENTORY_Y")] 		public CFloat POS_INVENTORY_Y { get; set;}

		[Ordinal(5)] [RED("POS_ALCHEMY_X")] 		public CFloat POS_ALCHEMY_X { get; set;}

		[Ordinal(6)] [RED("POS_ALCHEMY_Y")] 		public CFloat POS_ALCHEMY_Y { get; set;}

		[Ordinal(7)] [RED("POS_CHAR_DEV_X")] 		public CFloat POS_CHAR_DEV_X { get; set;}

		[Ordinal(8)] [RED("POS_CHAR_DEV_Y")] 		public CFloat POS_CHAR_DEV_Y { get; set;}

		[Ordinal(9)] [RED("POS_MUTATIONS_X")] 		public CFloat POS_MUTATIONS_X { get; set;}

		[Ordinal(10)] [RED("POS_MUTATIONS_Y")] 		public CFloat POS_MUTATIONS_Y { get; set;}

		[Ordinal(11)] [RED("POS_MAP_X")] 		public CFloat POS_MAP_X { get; set;}

		[Ordinal(12)] [RED("POS_MAP_Y")] 		public CFloat POS_MAP_Y { get; set;}

		[Ordinal(13)] [RED("POS_QUESTS_X")] 		public CFloat POS_QUESTS_X { get; set;}

		[Ordinal(14)] [RED("POS_QUESTS_Y")] 		public CFloat POS_QUESTS_Y { get; set;}

		[Ordinal(15)] [RED("POS_GEEKPAGE_X")] 		public CFloat POS_GEEKPAGE_X { get; set;}

		[Ordinal(16)] [RED("POS_GEEKPAGE_Y")] 		public CFloat POS_GEEKPAGE_Y { get; set;}

		[Ordinal(17)] [RED("POS_DISMANTLE_X")] 		public CFloat POS_DISMANTLE_X { get; set;}

		[Ordinal(18)] [RED("POS_DISMANTLE_Y")] 		public CFloat POS_DISMANTLE_Y { get; set;}

		[Ordinal(19)] [RED("POS_RADIAL_X")] 		public CFloat POS_RADIAL_X { get; set;}

		[Ordinal(20)] [RED("POS_RADIAL_Y")] 		public CFloat POS_RADIAL_Y { get; set;}

		public W3TutorialManagerUIHandlerStateTutHandlerBaseState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateTutHandlerBaseState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}