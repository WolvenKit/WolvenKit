using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMeshTypeComponent : CDrawableComponent
	{
		[RED("forceLODLevel")] 		public CInt32 ForceLODLevel { get; set;}

		[RED("forceAutoHideDistance")] 		public CUInt16 ForceAutoHideDistance { get; set;}

		[RED("shadowImportanceBias")] 		public CEnum<EMeshShadowImportanceBias> ShadowImportanceBias { get; set;}

		[RED("defaultEffectParams")] 		public Vector DefaultEffectParams { get; set;}

		[RED("defaultEffectColor")] 		public CColor DefaultEffectColor { get; set;}

		public CMeshTypeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMeshTypeComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}