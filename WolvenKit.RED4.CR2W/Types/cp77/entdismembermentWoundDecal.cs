using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundDecal : CVariable
	{
		private Vector3 _offsetA;
		private Vector3 _offsetB;
		private CFloat _scale;
		private CFloat _fadeOrigin;
		private CFloat _fadePower;
		private CEnum<entdismembermentResourceSetMask> _resourceSets;
		private raRef<IMaterial> _material;

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
		public raRef<IMaterial> Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		public entdismembermentWoundDecal(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
