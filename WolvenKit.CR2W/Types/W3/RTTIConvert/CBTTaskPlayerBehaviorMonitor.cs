using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayerBehaviorMonitor : IBehTreeTask
	{
		[Ordinal(1)] [RED("eventNameToRaise")] 		public CName EventNameToRaise { get; set;}

		[Ordinal(2)] [RED("scanningCooldown")] 		public CFloat ScanningCooldown { get; set;}

		[Ordinal(3)] [RED("extraWindow")] 		public CFloat ExtraWindow { get; set;}

		[Ordinal(4)] [RED("sendEvent")] 		public CBool SendEvent { get; set;}

		public CBTTaskPlayerBehaviorMonitor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlayerBehaviorMonitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}