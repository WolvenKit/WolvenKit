using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableInt : animAnimVariable
	{
		private CInt32 _value;
		private CInt32 _default;
		private CInt32 _min;
		private CInt32 _max;

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(3)] 
		[RED("default")] 
		public CInt32 Default
		{
			get => GetProperty(ref _default);
			set => SetProperty(ref _default, value);
		}

		[Ordinal(4)] 
		[RED("min")] 
		public CInt32 Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(5)] 
		[RED("max")] 
		public CInt32 Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}

		public animAnimVariableInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
