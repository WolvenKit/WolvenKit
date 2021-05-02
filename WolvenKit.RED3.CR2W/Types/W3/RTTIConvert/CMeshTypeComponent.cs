using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMeshTypeComponent : CDrawableComponent
	{
		[Ordinal(1)] [RED("forceLODLevel")] 		public CInt32 ForceLODLevel { get; set;}

		[Ordinal(2)] [RED("forceAutoHideDistance")] 		public CUInt16 ForceAutoHideDistance { get; set;}

		[Ordinal(3)] [RED("shadowImportanceBias")] 		public CEnum<EMeshShadowImportanceBias> ShadowImportanceBias { get; set;}

		[Ordinal(4)] [RED("defaultEffectParams")] 		public Vector DefaultEffectParams { get; set;}

		[Ordinal(5)] [RED("defaultEffectColor")] 		public CColor DefaultEffectColor { get; set;}

		public CMeshTypeComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}