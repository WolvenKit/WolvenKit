using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CActionPointComponent : CWayPointComponent
	{
		[Ordinal(0)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(0)] [RED("jobTreeRes")] 		public CHandle<CJobTree> JobTreeRes { get; set;}

		[Ordinal(0)] [RED("actionBreakable")] 		public CBool ActionBreakable { get; set;}

		[Ordinal(0)] [RED("breakableByCutscene")] 		public CBool BreakableByCutscene { get; set;}

		[Ordinal(0)] [RED("preferredNextAPs")] 		public TagList PreferredNextAPs { get; set;}

		[Ordinal(0)] [RED("activateOnStart")] 		public CBool ActivateOnStart { get; set;}

		[Ordinal(0)] [RED("placementImportance")] 		public CEnum<EWorkPlacementImportance> PlacementImportance { get; set;}

		[Ordinal(0)] [RED("ignoreCollosions")] 		public CBool IgnoreCollosions { get; set;}

		[Ordinal(0)] [RED("disableSoftReactions")] 		public CBool DisableSoftReactions { get; set;}

		[Ordinal(0)] [RED("fireSourceDependent")] 		public CBool FireSourceDependent { get; set;}

		[Ordinal(0)] [RED("forceKeepIKactive")] 		public CBool ForceKeepIKactive { get; set;}

		[Ordinal(0)] [RED("customWorkTree")] 		public CPtr<CAIPerformCustomWorkTree> CustomWorkTree { get; set;}

		[Ordinal(0)] [RED("eventWorkStarted", 2,0)] 		public CArray<CPtr<IPerformableAction>> EventWorkStarted { get; set;}

		[Ordinal(0)] [RED("eventWorkEnded", 2,0)] 		public CArray<CPtr<IPerformableAction>> EventWorkEnded { get; set;}

		public CActionPointComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CActionPointComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}