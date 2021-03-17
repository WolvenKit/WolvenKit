using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkScanlineWipeEffect : inkIEffect
	{
		private CFloat _angle;
		private CFloat _transition;
		private CFloat _width;

		[Ordinal(2)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetProperty(ref _angle);
			set => SetProperty(ref _angle, value);
		}

		[Ordinal(3)] 
		[RED("transition")] 
		public CFloat Transition
		{
			get => GetProperty(ref _transition);
			set => SetProperty(ref _transition, value);
		}

		[Ordinal(4)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		public inkScanlineWipeEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
