using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeCombatTargetSelectionTask : IBehTreeTask
	{
		[RED("maxTargetDistance")] 		public CFloat MaxTargetDistance { get; set;}

		[RED("testMaxFrequency")] 		public CFloat TestMaxFrequency { get; set;}

		[RED("nextTestDelay")] 		public CFloat NextTestDelay { get; set;}

		[RED("nextTarget")] 		public CHandle<CActor> NextTarget { get; set;}

		[RED("playerPriority")] 		public CInt32 PlayerPriority { get; set;}

		[RED("targetOnlyPlayer")] 		public CBool TargetOnlyPlayer { get; set;}

		[RED("ForceTarget")] 		public CHandle<CActor> ForceTarget { get; set;}

		public CBehTreeCombatTargetSelectionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeCombatTargetSelectionTask(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}