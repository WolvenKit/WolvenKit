using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CriticalEffect : CBaseGameplayEffect
	{
		[RED("criticalStateType")] 		public CEnum<ECriticalStateType> CriticalStateType { get; set;}

		[RED("allowedHits", 2,0)] 		public CArray<CBool> AllowedHits { get; set;}

		[RED("timeEndedHandled")] 		public CBool TimeEndedHandled { get; set;}

		[RED("isDestroyedOnInterrupt")] 		public CBool IsDestroyedOnInterrupt { get; set;}

		[RED("canPlayAnimation")] 		public CBool CanPlayAnimation { get; set;}

		[RED("blockedActions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> BlockedActions { get; set;}

		[RED("postponeHandling")] 		public CEnum<ECriticalHandling> PostponeHandling { get; set;}

		[RED("airHandling")] 		public CEnum<ECriticalHandling> AirHandling { get; set;}

		[RED("attachedHandling")] 		public CEnum<ECriticalHandling> AttachedHandling { get; set;}

		[RED("onHorseHandling")] 		public CEnum<ECriticalHandling> OnHorseHandling { get; set;}

		[RED("explorationStateHandling")] 		public CEnum<ECriticalHandling> ExplorationStateHandling { get; set;}

		[RED("usesFullBodyAnim")] 		public CBool UsesFullBodyAnim { get; set;}

		public W3CriticalEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3CriticalEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}