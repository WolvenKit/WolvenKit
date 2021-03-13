using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IMaterialDefinition : IMaterial
	{
		[Ordinal(1)] [RED("paramBlockSize", 3)] public CArrayFixedSize<CUInt32> ParamBlockSize { get; set; }
		[Ordinal(2)] [RED("compileAllTechniques")] public CBool CompileAllTechniques { get; set; }
		[Ordinal(3)] [RED("canHaveTangentUpdate")] public CBool CanHaveTangentUpdate { get; set; }
		[Ordinal(4)] [RED("canHaveDismemberment")] public CBool CanHaveDismemberment { get; set; }
		[Ordinal(5)] [RED("hasDPL")] public CBool HasDPL { get; set; }
		[Ordinal(6)] [RED("materialVersion")] public CUInt8 MaterialVersion { get; set; }
		[Ordinal(7)] [RED("vertexFactories")] public CArray<CEnum<EMaterialVertexFactory>> VertexFactories { get; set; }

		public IMaterialDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
