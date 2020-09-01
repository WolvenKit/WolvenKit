using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SKeyBinding : CVariable
	{
		[Ordinal(0)] [RED("("ActionID")] 		public CInt32 ActionID { get; set;}

		[Ordinal(0)] [RED("("LocalizationKey")] 		public CString LocalizationKey { get; set;}

		[Ordinal(0)] [RED("("Gamepad_NavCode")] 		public CString Gamepad_NavCode { get; set;}

		[Ordinal(0)] [RED("("Keyboard_KeyCode")] 		public CInt32 Keyboard_KeyCode { get; set;}

		[Ordinal(0)] [RED("("Enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(0)] [RED("("IsLocalized")] 		public CBool IsLocalized { get; set;}

		[Ordinal(0)] [RED("("IsHold")] 		public CBool IsHold { get; set;}

		public SKeyBinding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SKeyBinding(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}