using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMenuResource : IGuiResource
	{
		[Ordinal(1)] [RED("menuClass")] 		public CName MenuClass { get; set;}

		[Ordinal(2)] [RED("menuFlashSwf")] 		public CSoft<CSwfResource> MenuFlashSwf { get; set;}

		[Ordinal(3)] [RED("layer")] 		public CUInt32 Layer { get; set;}

		[Ordinal(4)] [RED("menuDef")] 		public CPtr<CMenuDef> MenuDef { get; set;}

		public CMenuResource(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}