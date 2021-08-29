using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IMaterialDefinition : IMaterial
	{
		private CArrayFixedSize<CUInt32> _paramBlockSize;
		private CBool _compileAllTechniques;
		private CBool _canHaveTangentUpdate;
		private CBool _canHaveDismemberment;
		private CBool _hasDPL;
		private CUInt8 _materialVersion;
		private CArray<CEnum<EMaterialVertexFactory>> _vertexFactories;

		[Ordinal(1)] 
		[RED("paramBlockSize", 3)] 
		public CArrayFixedSize<CUInt32> ParamBlockSize
		{
			get => GetProperty(ref _paramBlockSize);
			set => SetProperty(ref _paramBlockSize, value);
		}

		[Ordinal(2)] 
		[RED("compileAllTechniques")] 
		public CBool CompileAllTechniques
		{
			get => GetProperty(ref _compileAllTechniques);
			set => SetProperty(ref _compileAllTechniques, value);
		}

		[Ordinal(3)] 
		[RED("canHaveTangentUpdate")] 
		public CBool CanHaveTangentUpdate
		{
			get => GetProperty(ref _canHaveTangentUpdate);
			set => SetProperty(ref _canHaveTangentUpdate, value);
		}

		[Ordinal(4)] 
		[RED("canHaveDismemberment")] 
		public CBool CanHaveDismemberment
		{
			get => GetProperty(ref _canHaveDismemberment);
			set => SetProperty(ref _canHaveDismemberment, value);
		}

		[Ordinal(5)] 
		[RED("hasDPL")] 
		public CBool HasDPL
		{
			get => GetProperty(ref _hasDPL);
			set => SetProperty(ref _hasDPL, value);
		}

		[Ordinal(6)] 
		[RED("materialVersion")] 
		public CUInt8 MaterialVersion
		{
			get => GetProperty(ref _materialVersion);
			set => SetProperty(ref _materialVersion, value);
		}

		[Ordinal(7)] 
		[RED("vertexFactories")] 
		public CArray<CEnum<EMaterialVertexFactory>> VertexFactories
		{
			get => GetProperty(ref _vertexFactories);
			set => SetProperty(ref _vertexFactories, value);
		}
	}
}
