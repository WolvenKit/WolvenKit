using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CriticalDOTEffect : W3DamageOverTimeEffect
	{
		[Ordinal(0)] [RED("("criticalStateType")] 		public CEnum<ECriticalStateType> CriticalStateType { get; set;}

		[Ordinal(0)] [RED("("allowedHits", 2,0)] 		public CArray<CBool> AllowedHits { get; set;}

		[Ordinal(0)] [RED("("timeEndedHandled")] 		public CBool TimeEndedHandled { get; set;}

		[Ordinal(0)] [RED("("isDestroyedOnInterrupt")] 		public CBool IsDestroyedOnInterrupt { get; set;}

		[Ordinal(0)] [RED("("canPlayAnimation")] 		public CBool CanPlayAnimation { get; set;}

		[Ordinal(0)] [RED("("blockedActions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> BlockedActions { get; set;}

		[Ordinal(0)] [RED("("postponeHandling")] 		public CEnum<ECriticalHandling> PostponeHandling { get; set;}

		[Ordinal(0)] [RED("("airHandling")] 		public CEnum<ECriticalHandling> AirHandling { get; set;}

		[Ordinal(0)] [RED("("attachedHandling")] 		public CEnum<ECriticalHandling> AttachedHandling { get; set;}

		[Ordinal(0)] [RED("("onHorseHandling")] 		public CEnum<ECriticalHandling> OnHorseHandling { get; set;}

		[Ordinal(0)] [RED("("explorationStateHandling")] 		public CEnum<ECriticalHandling> ExplorationStateHandling { get; set;}

		[Ordinal(0)] [RED("("usesFullBodyAnim")] 		public CBool UsesFullBodyAnim { get; set;}

		public W3CriticalDOTEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3CriticalDOTEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}