using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HDRColor : CVariable
	{
		private CFloat _red;
		private CFloat _green;
		private CFloat _blue;
		private CFloat _alpha;

		[Ordinal(0)] 
		[RED("Red")] 
		public CFloat Red
		{
			get => GetProperty(ref _red);
			set => SetProperty(ref _red, value);
		}

		[Ordinal(1)] 
		[RED("Green")] 
		public CFloat Green
		{
			get => GetProperty(ref _green);
			set => SetProperty(ref _green, value);
		}

		[Ordinal(2)] 
		[RED("Blue")] 
		public CFloat Blue
		{
			get => GetProperty(ref _blue);
			set => SetProperty(ref _blue, value);
		}

		[Ordinal(3)] 
		[RED("Alpha")] 
		public CFloat Alpha
		{
			get => GetProperty(ref _alpha);
			set => SetProperty(ref _alpha, value);
		}

		public HDRColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
