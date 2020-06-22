using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PopupData : CObject
	{
		[RED("ButtonsDef", 2,0)] 		public CArray<SKeyBinding> ButtonsDef { get; set;}

		[RED("PopupRef")] 		public CHandle<CR4MenuPopup> PopupRef { get; set;}

		[RED("ScreenPosX")] 		public CFloat ScreenPosX { get; set;}

		[RED("ScreenPosY")] 		public CFloat ScreenPosY { get; set;}

		[RED("BlurBackground")] 		public CBool BlurBackground { get; set;}

		[RED("PauseGame")] 		public CBool PauseGame { get; set;}

		[RED("HideTutorial")] 		public CBool HideTutorial { get; set;}

		public W3PopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}