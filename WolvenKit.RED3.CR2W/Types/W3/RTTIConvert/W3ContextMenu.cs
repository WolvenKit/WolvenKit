using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ContextMenu : W3PopupData
	{
		[Ordinal(1)] [RED("positionX")] 		public CFloat PositionX { get; set;}

		[Ordinal(2)] [RED("positionY")] 		public CFloat PositionY { get; set;}

		[Ordinal(3)] [RED("contextRef")] 		public CHandle<W3UIContext> ContextRef { get; set;}

		[Ordinal(4)] [RED("actionsList", 2,0)] 		public CArray<SKeyBinding> ActionsList { get; set;}

		[Ordinal(5)] [RED("curActionNavCode")] 		public CString CurActionNavCode { get; set;}

		public W3ContextMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ContextMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}