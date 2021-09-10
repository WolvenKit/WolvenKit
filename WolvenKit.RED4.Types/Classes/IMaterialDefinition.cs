using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IMaterialDefinition : IMaterial
	{
		[Ordinal(1)] 
		[RED("paramBlockSize", 3)] 
		public CArrayFixedSize<CUInt32> ParamBlockSize
		{
			get => GetPropertyValue<CArrayFixedSize<CUInt32>>();
			set => SetPropertyValue<CArrayFixedSize<CUInt32>>(value);
		}

		[Ordinal(2)] 
		[RED("compileAllTechniques")] 
		public CBool CompileAllTechniques
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("canHaveTangentUpdate")] 
		public CBool CanHaveTangentUpdate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("canHaveDismemberment")] 
		public CBool CanHaveDismemberment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("hasDPL")] 
		public CBool HasDPL
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("materialVersion")] 
		public CUInt8 MaterialVersion
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(7)] 
		[RED("vertexFactories")] 
		public CArray<CEnum<EMaterialVertexFactory>> VertexFactories
		{
			get => GetPropertyValue<CArray<CEnum<EMaterialVertexFactory>>>();
			set => SetPropertyValue<CArray<CEnum<EMaterialVertexFactory>>>(value);
		}
	}
}
