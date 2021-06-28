using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DOFControl : animAnimFeature
	{
		private CFloat _dofIntensity;
		private CFloat _dofNearBlur;
		private CFloat _dofNearFocus;
		private CFloat _dofFarBlur;
		private CFloat _dofFarFocus;
		private CFloat _dofBlendInTime;
		private CFloat _dofBlendOutTime;

		[Ordinal(0)] 
		[RED("dofIntensity")] 
		public CFloat DofIntensity
		{
			get => GetProperty(ref _dofIntensity);
			set => SetProperty(ref _dofIntensity, value);
		}

		[Ordinal(1)] 
		[RED("dofNearBlur")] 
		public CFloat DofNearBlur
		{
			get => GetProperty(ref _dofNearBlur);
			set => SetProperty(ref _dofNearBlur, value);
		}

		[Ordinal(2)] 
		[RED("dofNearFocus")] 
		public CFloat DofNearFocus
		{
			get => GetProperty(ref _dofNearFocus);
			set => SetProperty(ref _dofNearFocus, value);
		}

		[Ordinal(3)] 
		[RED("dofFarBlur")] 
		public CFloat DofFarBlur
		{
			get => GetProperty(ref _dofFarBlur);
			set => SetProperty(ref _dofFarBlur, value);
		}

		[Ordinal(4)] 
		[RED("dofFarFocus")] 
		public CFloat DofFarFocus
		{
			get => GetProperty(ref _dofFarFocus);
			set => SetProperty(ref _dofFarFocus, value);
		}

		[Ordinal(5)] 
		[RED("dofBlendInTime")] 
		public CFloat DofBlendInTime
		{
			get => GetProperty(ref _dofBlendInTime);
			set => SetProperty(ref _dofBlendInTime, value);
		}

		[Ordinal(6)] 
		[RED("dofBlendOutTime")] 
		public CFloat DofBlendOutTime
		{
			get => GetProperty(ref _dofBlendOutTime);
			set => SetProperty(ref _dofBlendOutTime, value);
		}

		public AnimFeature_DOFControl(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
