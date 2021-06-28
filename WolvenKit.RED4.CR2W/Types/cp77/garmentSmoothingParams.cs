using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class garmentSmoothingParams : CVariable
	{
		private CFloat _smoothingStrength;
		private CFloat _smoothingRadiusInCM;
		private CFloat _smoothingExponent;
		private CUInt32 _smoothingNumNeighbours;

		[Ordinal(0)] 
		[RED("smoothingStrength")] 
		public CFloat SmoothingStrength
		{
			get => GetProperty(ref _smoothingStrength);
			set => SetProperty(ref _smoothingStrength, value);
		}

		[Ordinal(1)] 
		[RED("smoothingRadiusInCM")] 
		public CFloat SmoothingRadiusInCM
		{
			get => GetProperty(ref _smoothingRadiusInCM);
			set => SetProperty(ref _smoothingRadiusInCM, value);
		}

		[Ordinal(2)] 
		[RED("smoothingExponent")] 
		public CFloat SmoothingExponent
		{
			get => GetProperty(ref _smoothingExponent);
			set => SetProperty(ref _smoothingExponent, value);
		}

		[Ordinal(3)] 
		[RED("smoothingNumNeighbours")] 
		public CUInt32 SmoothingNumNeighbours
		{
			get => GetProperty(ref _smoothingNumNeighbours);
			set => SetProperty(ref _smoothingNumNeighbours, value);
		}

		public garmentSmoothingParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
