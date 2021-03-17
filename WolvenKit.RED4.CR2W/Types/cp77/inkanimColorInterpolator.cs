using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimColorInterpolator : inkanimInterpolator
	{
		private HDRColor _startValue;
		private HDRColor _endValue;

		[Ordinal(7)] 
		[RED("startValue")] 
		public HDRColor StartValue
		{
			get => GetProperty(ref _startValue);
			set => SetProperty(ref _startValue, value);
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public HDRColor EndValue
		{
			get => GetProperty(ref _endValue);
			set => SetProperty(ref _endValue, value);
		}

		public inkanimColorInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
