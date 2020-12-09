using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Switch : CGameplayEntity
	{
		[Ordinal(1)] [RED("isInitiallyEnabled")] 		public CBool IsInitiallyEnabled { get; set;}

		[Ordinal(2)] [RED("isInitiallyLocked")] 		public CBool IsInitiallyLocked { get; set;}

		[Ordinal(3)] [RED("isInitiallyOn")] 		public CBool IsInitiallyOn { get; set;}

		[Ordinal(4)] [RED("maxUseCount")] 		public CInt32 MaxUseCount { get; set;}

		[Ordinal(5)] [RED("skipEventsAtBeginning")] 		public CBool SkipEventsAtBeginning { get; set;}

		[Ordinal(6)] [RED("whenOnEvents", 2,0)] 		public CArray<CHandle<W3SwitchEvent>> WhenOnEvents { get; set;}

		[Ordinal(7)] [RED("whenOffEvents", 2,0)] 		public CArray<CHandle<W3SwitchEvent>> WhenOffEvents { get; set;}

		[Ordinal(8)] [RED("whenSwitchedEvents", 2,0)] 		public CArray<CHandle<W3SwitchEvent>> WhenSwitchedEvents { get; set;}

		[Ordinal(9)] [RED("currentState")] 		public CEnum<ESwitchState> CurrentState { get; set;}

		[Ordinal(10)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(11)] [RED("locked")] 		public CBool Locked { get; set;}

		[Ordinal(12)] [RED("totalUseCount")] 		public CInt32 TotalUseCount { get; set;}

		[Ordinal(13)] [RED("skipEvents")] 		public CBool SkipEvents { get; set;}

		[Ordinal(14)] [RED("virtualSwitchesLinkedHandle", 2,0)] 		public CArray<EntityHandle> VirtualSwitchesLinkedHandle { get; set;}

		[Ordinal(15)] [RED("lastActivatorHandle")] 		public EntityHandle LastActivatorHandle { get; set;}

		[Ordinal(16)] [RED("restoreUsableItemL")] 		public CBool RestoreUsableItemL { get; set;}

		[Ordinal(17)] [RED("BEH_ON")] 		public CFloat BEH_ON { get; set;}

		[Ordinal(18)] [RED("BEH_OFF")] 		public CFloat BEH_OFF { get; set;}

		[Ordinal(19)] [RED("BEH_ON_FROM_OFF")] 		public CFloat BEH_ON_FROM_OFF { get; set;}

		[Ordinal(20)] [RED("BEH_OFF_FROM_ON")] 		public CFloat BEH_OFF_FROM_ON { get; set;}

		public W3Switch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Switch(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}