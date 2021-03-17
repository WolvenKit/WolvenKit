using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetAIState : CVariable
	{
		private CInt32 _value;
		private CInt32 _prevValue;
		private CFloat _time;

		[Ordinal(0)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("prevValue")] 
		public CInt32 PrevValue
		{
			get => GetProperty(ref _prevValue);
			set => SetProperty(ref _prevValue, value);
		}

		[Ordinal(2)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		public gameNetAIState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
