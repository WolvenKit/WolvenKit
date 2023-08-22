using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class IMaterialDefinition : IMaterial
	{
		[Ordinal(1)] 
		[RED("paramBlockSize", 3)] 
		public CArrayFixedSize<CUInt32> ParamBlockSize
		{
			get => GetPropertyValue<CArrayFixedSize<CUInt32>>();
			set => SetPropertyValue<CArrayFixedSize<CUInt32>>(value);
		}

		[Ordinal(2)] 
		[RED("canHaveTangentUpdate")] 
		public CBool CanHaveTangentUpdate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("canHaveDismemberment")] 
		public CBool CanHaveDismemberment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("hasDPL")] 
		public CBool HasDPL
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("canBeMasked")] 
		public CBool CanBeMasked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("shadingRateMode")] 
		public CEnum<EMaterialShadingRateMode> ShadingRateMode
		{
			get => GetPropertyValue<CEnum<EMaterialShadingRateMode>>();
			set => SetPropertyValue<CEnum<EMaterialShadingRateMode>>(value);
		}

		[Ordinal(7)] 
		[RED("materialVersion")] 
		public CUInt8 MaterialVersion
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(8)] 
		[RED("vertexFactories")] 
		public CArray<CEnum<EMaterialVertexFactory>> VertexFactories
		{
			get => GetPropertyValue<CArray<CEnum<EMaterialVertexFactory>>>();
			set => SetPropertyValue<CArray<CEnum<EMaterialVertexFactory>>>(value);
		}

		public IMaterialDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
