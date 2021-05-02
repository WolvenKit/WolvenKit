using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4MenuPopup : CR4OverlayMenu
	{
		[Ordinal(1)] [RED("m_DataObject")] 		public CHandle<W3PopupData> M_DataObject { get; set;}

		[Ordinal(2)] [RED("m_initialized")] 		public CBool M_initialized { get; set;}

		[Ordinal(3)] [RED("m_HideTutorial")] 		public CBool M_HideTutorial { get; set;}

		[Ordinal(4)] [RED("m_fxSetBarValueSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetBarValueSFF { get; set;}

		[Ordinal(5)] [RED("rttItemLoaded")] 		public CBool RttItemLoaded { get; set;}

		[Ordinal(6)] [RED("itemRotation")] 		public EulerAngles ItemRotation { get; set;}

		[Ordinal(7)] [RED("itemPosition")] 		public Vector ItemPosition { get; set;}

		[Ordinal(8)] [RED("itemScale")] 		public Vector ItemScale { get; set;}

		[Ordinal(9)] [RED("itemCat")] 		public CName ItemCat { get; set;}

		public CR4MenuPopup(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4MenuPopup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}