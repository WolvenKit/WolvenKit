using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkRectangle : CVariable
	{
		private CFloat _x;
		private CFloat _y;
		private CFloat _width;
		private CFloat _height;

		[Ordinal(0)] 
		[RED("x")] 
		public CFloat X
		{
			get => GetProperty(ref _x);
			set => SetProperty(ref _x, value);
		}

		[Ordinal(1)] 
		[RED("y")] 
		public CFloat Y
		{
			get => GetProperty(ref _y);
			set => SetProperty(ref _y, value);
		}

		[Ordinal(2)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(3)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		public inkRectangle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
