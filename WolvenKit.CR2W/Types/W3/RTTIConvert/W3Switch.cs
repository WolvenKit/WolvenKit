using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Switch : CGameplayEntity
	{
		[RED("isInitiallyEnabled")] 		public CBool IsInitiallyEnabled { get; set;}

		[RED("isInitiallyLocked")] 		public CBool IsInitiallyLocked { get; set;}

		[RED("isInitiallyOn")] 		public CBool IsInitiallyOn { get; set;}

		[RED("maxUseCount")] 		public CInt32 MaxUseCount { get; set;}

		[RED("skipEventsAtBeginning")] 		public CBool SkipEventsAtBeginning { get; set;}

		[RED("whenOnEvents", 2,0)] 		public CArray<CHandle<W3SwitchEvent>> WhenOnEvents { get; set;}

		[RED("whenOffEvents", 2,0)] 		public CArray<CHandle<W3SwitchEvent>> WhenOffEvents { get; set;}

		[RED("whenSwitchedEvents", 2,0)] 		public CArray<CHandle<W3SwitchEvent>> WhenSwitchedEvents { get; set;}

		public W3Switch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Switch(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}