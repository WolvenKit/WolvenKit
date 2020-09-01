using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ContextMenu : W3PopupData
	{
		[Ordinal(0)] [RED("("positionX")] 		public CFloat PositionX { get; set;}

		[Ordinal(0)] [RED("("positionY")] 		public CFloat PositionY { get; set;}

		[Ordinal(0)] [RED("("contextRef")] 		public CHandle<W3UIContext> ContextRef { get; set;}

		[Ordinal(0)] [RED("("actionsList", 2,0)] 		public CArray<SKeyBinding> ActionsList { get; set;}

		[Ordinal(0)] [RED("("curActionNavCode")] 		public CString CurActionNavCode { get; set;}

		public W3ContextMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ContextMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}