using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPopupResource : IGuiResource
	{
		[Ordinal(0)] [RED("popupClass")] 		public CName PopupClass { get; set;}

		[Ordinal(0)] [RED("popupFlashSwf")] 		public CSoft<CSwfResource> PopupFlashSwf { get; set;}

		[Ordinal(0)] [RED("layer")] 		public CUInt32 Layer { get; set;}

		[Ordinal(0)] [RED("popupDef")] 		public CPtr<CPopupDef> PopupDef { get; set;}

		public CPopupResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPopupResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}