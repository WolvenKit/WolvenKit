using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWasInCriticalState : IBehTreeTask
	{
		[Ordinal(0)] [RED("("timeDifference")] 		public CFloat TimeDifference { get; set;}

		[Ordinal(0)] [RED("("maxTimeDifference")] 		public CFloat MaxTimeDifference { get; set;}

		[Ordinal(0)] [RED("("criticalState")] 		public CEnum<ECriticalStateType> CriticalState { get; set;}

		[Ordinal(0)] [RED("("timeOfLastCSDeactivation")] 		public CFloat TimeOfLastCSDeactivation { get; set;}

		[Ordinal(0)] [RED("("combatDataStorage")] 		public CHandle<CBaseAICombatStorage> CombatDataStorage { get; set;}

		public CBTTaskWasInCriticalState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskWasInCriticalState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}