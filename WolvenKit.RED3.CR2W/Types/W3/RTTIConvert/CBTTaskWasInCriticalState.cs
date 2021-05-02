using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWasInCriticalState : IBehTreeTask
	{
		[Ordinal(1)] [RED("timeDifference")] 		public CFloat TimeDifference { get; set;}

		[Ordinal(2)] [RED("maxTimeDifference")] 		public CFloat MaxTimeDifference { get; set;}

		[Ordinal(3)] [RED("criticalState")] 		public CEnum<ECriticalStateType> CriticalState { get; set;}

		[Ordinal(4)] [RED("timeOfLastCSDeactivation")] 		public CFloat TimeOfLastCSDeactivation { get; set;}

		[Ordinal(5)] [RED("combatDataStorage")] 		public CHandle<CBaseAICombatStorage> CombatDataStorage { get; set;}

		public CBTTaskWasInCriticalState(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskWasInCriticalState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}