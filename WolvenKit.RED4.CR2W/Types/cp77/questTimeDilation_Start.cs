using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_Start : questTimeDilation_Operation
	{
		private CFloat _dilation;
		private CFloat _duration;
		private CName _easeInCurve;
		private CName _easeOutCurve;

		[Ordinal(0)] 
		[RED("dilation")] 
		public CFloat Dilation
		{
			get => GetProperty(ref _dilation);
			set => SetProperty(ref _dilation, value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(2)] 
		[RED("easeInCurve")] 
		public CName EaseInCurve
		{
			get => GetProperty(ref _easeInCurve);
			set => SetProperty(ref _easeInCurve, value);
		}

		[Ordinal(3)] 
		[RED("easeOutCurve")] 
		public CName EaseOutCurve
		{
			get => GetProperty(ref _easeOutCurve);
			set => SetProperty(ref _easeOutCurve, value);
		}

		public questTimeDilation_Start(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
