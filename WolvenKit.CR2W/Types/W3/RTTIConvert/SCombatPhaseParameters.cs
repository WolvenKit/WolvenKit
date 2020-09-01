using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCombatPhaseParameters : CVariable
	{
		[Ordinal(1)] [RED("("setBehVariable")] 		public CInt32 SetBehVariable { get; set;}

		[Ordinal(2)] [RED("("priority")] 		public CFloat Priority { get; set;}

		[Ordinal(3)] [RED("("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(4)] [RED("("cooldown")] 		public CFloat Cooldown { get; set;}

		[Ordinal(5)] [RED("("timerRandomization")] 		public CFloat TimerRandomization { get; set;}

		[Ordinal(6)] [RED("("minRangeFromTarget")] 		public CFloat MinRangeFromTarget { get; set;}

		[Ordinal(7)] [RED("("maxRangeFromTarget")] 		public CFloat MaxRangeFromTarget { get; set;}

		[Ordinal(8)] [RED("("activationAnimEvent")] 		public CName ActivationAnimEvent { get; set;}

		[Ordinal(9)] [RED("("deactivationAnimEvent")] 		public CName DeactivationAnimEvent { get; set;}

		[Ordinal(10)] [RED("("activationGameplayEvent")] 		public CName ActivationGameplayEvent { get; set;}

		[Ordinal(11)] [RED("("deactivationGameplayEvent")] 		public CName DeactivationGameplayEvent { get; set;}

		public SCombatPhaseParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCombatPhaseParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}