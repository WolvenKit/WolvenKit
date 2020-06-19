using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGuiConfigResource : CResource
	{
		[RED("huds", 2,0)] 		public CArray<SHudDescription> Huds { get; set;}

		[RED("menus", 2,0)] 		public CArray<SMenuDescription> Menus { get; set;}

		[RED("popups", 2,0)] 		public CArray<SPopupDescription> Popups { get; set;}

		[RED("scene")] 		public SGuiSceneDescription Scene { get; set;}

		public CGuiConfigResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGuiConfigResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}