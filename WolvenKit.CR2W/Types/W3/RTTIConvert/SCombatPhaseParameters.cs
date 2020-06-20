using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCombatPhaseParameters : CVariable
	{
		[RED("setBehVariable")] 		public CInt32 SetBehVariable { get; set;}

		[RED("priority")] 		public CFloat Priority { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[RED("timerRandomization")] 		public CFloat TimerRandomization { get; set;}

		[RED("minRangeFromTarget")] 		public CFloat MinRangeFromTarget { get; set;}

		[RED("maxRangeFromTarget")] 		public CFloat MaxRangeFromTarget { get; set;}

		[RED("activationAnimEvent")] 		public CName ActivationAnimEvent { get; set;}

		[RED("deactivationAnimEvent")] 		public CName DeactivationAnimEvent { get; set;}

		[RED("activationGameplayEvent")] 		public CName ActivationGameplayEvent { get; set;}

		[RED("deactivationGameplayEvent")] 		public CName DeactivationGameplayEvent { get; set;}

		public SCombatPhaseParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCombatPhaseParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}