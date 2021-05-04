using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendSLightFlickering : CVariable
	{
		private CFloat _positionOffset;
		private CFloat _flickerStrength;
		private CFloat _flickerPeriod;

		[Ordinal(0)] 
		[RED("positionOffset")] 
		public CFloat PositionOffset
		{
			get => GetProperty(ref _positionOffset);
			set => SetProperty(ref _positionOffset, value);
		}

		[Ordinal(1)] 
		[RED("flickerStrength")] 
		public CFloat FlickerStrength
		{
			get => GetProperty(ref _flickerStrength);
			set => SetProperty(ref _flickerStrength, value);
		}

		[Ordinal(2)] 
		[RED("flickerPeriod")] 
		public CFloat FlickerPeriod
		{
			get => GetProperty(ref _flickerPeriod);
			set => SetProperty(ref _flickerPeriod, value);
		}

		public rendSLightFlickering(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
