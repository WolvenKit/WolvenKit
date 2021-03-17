using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileVelocityParams : CVariable
	{
		private CFloat _xFactor;
		private CFloat _yFactor;
		private CFloat _zFactor;

		[Ordinal(0)] 
		[RED("xFactor")] 
		public CFloat XFactor
		{
			get => GetProperty(ref _xFactor);
			set => SetProperty(ref _xFactor, value);
		}

		[Ordinal(1)] 
		[RED("yFactor")] 
		public CFloat YFactor
		{
			get => GetProperty(ref _yFactor);
			set => SetProperty(ref _yFactor, value);
		}

		[Ordinal(2)] 
		[RED("zFactor")] 
		public CFloat ZFactor
		{
			get => GetProperty(ref _zFactor);
			set => SetProperty(ref _zFactor, value);
		}

		public gameprojectileVelocityParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
