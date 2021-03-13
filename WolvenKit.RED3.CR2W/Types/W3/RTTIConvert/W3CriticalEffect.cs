using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CriticalEffect : CBaseGameplayEffect
	{
		[Ordinal(1)] [RED("criticalStateType")] 		public CEnum<ECriticalStateType> CriticalStateType { get; set;}

		[Ordinal(2)] [RED("allowedHits", 2,0)] 		public CArray<CBool> AllowedHits { get; set;}

		[Ordinal(3)] [RED("timeEndedHandled")] 		public CBool TimeEndedHandled { get; set;}

		[Ordinal(4)] [RED("isDestroyedOnInterrupt")] 		public CBool IsDestroyedOnInterrupt { get; set;}

		[Ordinal(5)] [RED("canPlayAnimation")] 		public CBool CanPlayAnimation { get; set;}

		[Ordinal(6)] [RED("blockedActions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> BlockedActions { get; set;}

		[Ordinal(7)] [RED("postponeHandling")] 		public CEnum<ECriticalHandling> PostponeHandling { get; set;}

		[Ordinal(8)] [RED("airHandling")] 		public CEnum<ECriticalHandling> AirHandling { get; set;}

		[Ordinal(9)] [RED("attachedHandling")] 		public CEnum<ECriticalHandling> AttachedHandling { get; set;}

		[Ordinal(10)] [RED("onHorseHandling")] 		public CEnum<ECriticalHandling> OnHorseHandling { get; set;}

		[Ordinal(11)] [RED("explorationStateHandling")] 		public CEnum<ECriticalHandling> ExplorationStateHandling { get; set;}

		[Ordinal(12)] [RED("usesFullBodyAnim")] 		public CBool UsesFullBodyAnim { get; set;}

		public W3CriticalEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3CriticalEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}