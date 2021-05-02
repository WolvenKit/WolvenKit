using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CActionPointComponent : CWayPointComponent
	{
		[Ordinal(1)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(2)] [RED("jobTreeRes")] 		public CHandle<CJobTree> JobTreeRes { get; set;}

		[Ordinal(3)] [RED("actionBreakable")] 		public CBool ActionBreakable { get; set;}

		[Ordinal(4)] [RED("breakableByCutscene")] 		public CBool BreakableByCutscene { get; set;}

		[Ordinal(5)] [RED("preferredNextAPs")] 		public TagList PreferredNextAPs { get; set;}

		[Ordinal(6)] [RED("activateOnStart")] 		public CBool ActivateOnStart { get; set;}

		[Ordinal(7)] [RED("placementImportance")] 		public CEnum<EWorkPlacementImportance> PlacementImportance { get; set;}

		[Ordinal(8)] [RED("ignoreCollosions")] 		public CBool IgnoreCollosions { get; set;}

		[Ordinal(9)] [RED("disableSoftReactions")] 		public CBool DisableSoftReactions { get; set;}

		[Ordinal(10)] [RED("fireSourceDependent")] 		public CBool FireSourceDependent { get; set;}

		[Ordinal(11)] [RED("forceKeepIKactive")] 		public CBool ForceKeepIKactive { get; set;}

		[Ordinal(12)] [RED("customWorkTree")] 		public CPtr<CAIPerformCustomWorkTree> CustomWorkTree { get; set;}

		[Ordinal(13)] [RED("eventWorkStarted", 2,0)] 		public CArray<CPtr<IPerformableAction>> EventWorkStarted { get; set;}

		[Ordinal(14)] [RED("eventWorkEnded", 2,0)] 		public CArray<CPtr<IPerformableAction>> EventWorkEnded { get; set;}

		public CActionPointComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}