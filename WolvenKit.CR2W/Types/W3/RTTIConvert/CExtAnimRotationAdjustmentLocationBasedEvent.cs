using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimRotationAdjustmentLocationBasedEvent : CExtAnimDurationEvent
	{
		[RED("locationAdjustmentVar")] 		public CName LocationAdjustmentVar { get; set;}

		[RED("targetLocationVar")] 		public CName TargetLocationVar { get; set;}

		[RED("adjustmentActiveVar")] 		public CName AdjustmentActiveVar { get; set;}

		public CExtAnimRotationAdjustmentLocationBasedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimRotationAdjustmentLocationBasedEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}