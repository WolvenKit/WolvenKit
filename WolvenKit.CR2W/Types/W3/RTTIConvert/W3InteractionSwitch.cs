using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3InteractionSwitch : W3PhysicalSwitch
	{
		[Ordinal(1)] [RED("("isActivatedByPlayer")] 		public CBool IsActivatedByPlayer { get; set;}

		[Ordinal(2)] [RED("("focusModeHighlight")] 		public CEnum<EFocusModeVisibility> FocusModeHighlight { get; set;}

		[Ordinal(3)] [RED("("interactionActiveInState")] 		public CEnum<ESwitchState> InteractionActiveInState { get; set;}

		public W3InteractionSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3InteractionSwitch(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}