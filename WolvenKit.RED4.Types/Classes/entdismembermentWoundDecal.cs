using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentWoundDecal : RedBaseClass
	{
		private Vector3 _offsetA;
		private Vector3 _offsetB;
		private CFloat _scale;
		private CFloat _fadeOrigin;
		private CFloat _fadePower;
		private CEnum<entdismembermentResourceSetMask> _resourceSets;
		private CResourceAsyncReference<IMaterial> _material;

		[Ordinal(0)] 
		[RED("OffsetA")] 
		public Vector3 OffsetA
		{
			get => GetProperty(ref _offsetA);
			set => SetProperty(ref _offsetA, value);
		}

		[Ordinal(1)] 
		[RED("OffsetB")] 
		public Vector3 OffsetB
		{
			get => GetProperty(ref _offsetB);
			set => SetProperty(ref _offsetB, value);
		}

		[Ordinal(2)] 
		[RED("Scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(3)] 
		[RED("FadeOrigin")] 
		public CFloat FadeOrigin
		{
			get => GetProperty(ref _fadeOrigin);
			set => SetProperty(ref _fadeOrigin, value);
		}

		[Ordinal(4)] 
		[RED("FadePower")] 
		public CFloat FadePower
		{
			get => GetProperty(ref _fadePower);
			set => SetProperty(ref _fadePower, value);
		}

		[Ordinal(5)] 
		[RED("ResourceSets")] 
		public CEnum<entdismembermentResourceSetMask> ResourceSets
		{
			get => GetProperty(ref _resourceSets);
			set => SetProperty(ref _resourceSets, value);
		}

		[Ordinal(6)] 
		[RED("Material")] 
		public CResourceAsyncReference<IMaterial> Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		public entdismembermentWoundDecal()
		{
			_scale = 1.000000F;
			_fadeOrigin = 0.700000F;
			_fadePower = 1.000000F;
		}
	}
}
