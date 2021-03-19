using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayAnimEventData : CVariable
	{
		private CFloat _blendIn;
		private CFloat _blendOut;
		private CFloat _clipFront;
		private CFloat _clipEnd;
		private CFloat _stretch;
		private CEnum<scnEasingType> _blendInCurve;
		private CEnum<scnEasingType> _blendOutCurve;

		[Ordinal(0)] 
		[RED("blendIn")] 
		public CFloat BlendIn
		{
			get => GetProperty(ref _blendIn);
			set => SetProperty(ref _blendIn, value);
		}

		[Ordinal(1)] 
		[RED("blendOut")] 
		public CFloat BlendOut
		{
			get => GetProperty(ref _blendOut);
			set => SetProperty(ref _blendOut, value);
		}

		[Ordinal(2)] 
		[RED("clipFront")] 
		public CFloat ClipFront
		{
			get => GetProperty(ref _clipFront);
			set => SetProperty(ref _clipFront, value);
		}

		[Ordinal(3)] 
		[RED("clipEnd")] 
		public CFloat ClipEnd
		{
			get => GetProperty(ref _clipEnd);
			set => SetProperty(ref _clipEnd, value);
		}

		[Ordinal(4)] 
		[RED("stretch")] 
		public CFloat Stretch
		{
			get => GetProperty(ref _stretch);
			set => SetProperty(ref _stretch, value);
		}

		[Ordinal(5)] 
		[RED("blendInCurve")] 
		public CEnum<scnEasingType> BlendInCurve
		{
			get => GetProperty(ref _blendInCurve);
			set => SetProperty(ref _blendInCurve, value);
		}

		[Ordinal(6)] 
		[RED("blendOutCurve")] 
		public CEnum<scnEasingType> BlendOutCurve
		{
			get => GetProperty(ref _blendOutCurve);
			set => SetProperty(ref _blendOutCurve, value);
		}

		public scneventsPlayAnimEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
