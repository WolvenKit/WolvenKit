using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PopupData : CObject
	{
		[Ordinal(1)] [RED("ButtonsDef", 2,0)] 		public CArray<SKeyBinding> ButtonsDef { get; set;}

		[Ordinal(2)] [RED("PopupRef")] 		public CHandle<CR4MenuPopup> PopupRef { get; set;}

		[Ordinal(3)] [RED("ScreenPosX")] 		public CFloat ScreenPosX { get; set;}

		[Ordinal(4)] [RED("ScreenPosY")] 		public CFloat ScreenPosY { get; set;}

		[Ordinal(5)] [RED("BlurBackground")] 		public CBool BlurBackground { get; set;}

		[Ordinal(6)] [RED("PauseGame")] 		public CBool PauseGame { get; set;}

		[Ordinal(7)] [RED("HideTutorial")] 		public CBool HideTutorial { get; set;}

		public W3PopupData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}