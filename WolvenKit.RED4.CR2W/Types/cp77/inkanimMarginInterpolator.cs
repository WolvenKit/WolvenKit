using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimMarginInterpolator : inkanimInterpolator
	{
		private inkMargin _startValue;
		private inkMargin _endValue;

		[Ordinal(7)] 
		[RED("startValue")] 
		public inkMargin StartValue
		{
			get => GetProperty(ref _startValue);
			set => SetProperty(ref _startValue, value);
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public inkMargin EndValue
		{
			get => GetProperty(ref _endValue);
			set => SetProperty(ref _endValue, value);
		}

		public inkanimMarginInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
