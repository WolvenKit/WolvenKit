using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimCutsceneSlowMoEvent : CExtAnimCutsceneDurationEvent
	{
		[Ordinal(1)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(2)] [RED("factor")] 		public CFloat Factor { get; set;}

		[Ordinal(3)] [RED("useWeightCurve")] 		public CBool UseWeightCurve { get; set;}

		[Ordinal(4)] [RED("weightCurve")] 		public SCurveData WeightCurve { get; set;}

		public CExtAnimCutsceneSlowMoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimCutsceneSlowMoEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}