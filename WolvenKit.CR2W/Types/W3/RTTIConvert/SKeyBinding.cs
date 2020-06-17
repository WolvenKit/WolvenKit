using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SKeyBinding : CVariable
	{
		[RED("ActionID")] 		public CInt32 ActionID { get; set;}

		[RED("LocalizationKey")] 		public CString LocalizationKey { get; set;}

		[RED("Gamepad_NavCode")] 		public CString Gamepad_NavCode { get; set;}

		[RED("Keyboard_KeyCode")] 		public CInt32 Keyboard_KeyCode { get; set;}

		[RED("Enabled")] 		public CBool Enabled { get; set;}

		[RED("IsLocalized")] 		public CBool IsLocalized { get; set;}

		[RED("IsHold")] 		public CBool IsHold { get; set;}

		public SKeyBinding(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SKeyBinding(cr2w);

	}
}