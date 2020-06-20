using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CActionPointComponent : CWayPointComponent
	{
		[RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[RED("jobTreeRes")] 		public CHandle<CJobTree> JobTreeRes { get; set;}

		[RED("actionBreakable")] 		public CBool ActionBreakable { get; set;}

		[RED("breakableByCutscene")] 		public CBool BreakableByCutscene { get; set;}

		[RED("preferredNextAPs")] 		public TagList PreferredNextAPs { get; set;}

		[RED("activateOnStart")] 		public CBool ActivateOnStart { get; set;}

		[RED("placementImportance")] 		public CEnum<EWorkPlacementImportance> PlacementImportance { get; set;}

		[RED("ignoreCollosions")] 		public CBool IgnoreCollosions { get; set;}

		[RED("disableSoftReactions")] 		public CBool DisableSoftReactions { get; set;}

		[RED("fireSourceDependent")] 		public CBool FireSourceDependent { get; set;}

		[RED("forceKeepIKactive")] 		public CBool ForceKeepIKactive { get; set;}

		[RED("customWorkTree")] 		public CPtr<CAIPerformCustomWorkTree> CustomWorkTree { get; set;}

		[RED("eventWorkStarted", 2,0)] 		public CArray<CPtr<IPerformableAction>> EventWorkStarted { get; set;}

		[RED("eventWorkEnded", 2,0)] 		public CArray<CPtr<IPerformableAction>> EventWorkEnded { get; set;}

		public CActionPointComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CActionPointComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}