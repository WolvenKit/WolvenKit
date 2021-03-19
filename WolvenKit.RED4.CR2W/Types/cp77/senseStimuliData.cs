using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseStimuliData : IScriptable
	{
		private CFloat _interval;
		private CBool _isReactionStim;
		private CBool _isSecurityAreaExclusive;
		private CFloat _fearValue;
		private CFloat _shockValue;
		private CFloat _sadValue;
		private CFloat _joyValue;
		private CFloat _surpriseValue;
		private CFloat _disgustValue;
		private CFloat _aggressiveValue;
		private CFloat _funnyValue;
		private CFloat _curiosityValue;
		private CInt32 _stimPriority;

		[Ordinal(0)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get => GetProperty(ref _interval);
			set => SetProperty(ref _interval, value);
		}

		[Ordinal(1)] 
		[RED("isReactionStim")] 
		public CBool IsReactionStim
		{
			get => GetProperty(ref _isReactionStim);
			set => SetProperty(ref _isReactionStim, value);
		}

		[Ordinal(2)] 
		[RED("isSecurityAreaExclusive")] 
		public CBool IsSecurityAreaExclusive
		{
			get => GetProperty(ref _isSecurityAreaExclusive);
			set => SetProperty(ref _isSecurityAreaExclusive, value);
		}

		[Ordinal(3)] 
		[RED("fearValue")] 
		public CFloat FearValue
		{
			get => GetProperty(ref _fearValue);
			set => SetProperty(ref _fearValue, value);
		}

		[Ordinal(4)] 
		[RED("shockValue")] 
		public CFloat ShockValue
		{
			get => GetProperty(ref _shockValue);
			set => SetProperty(ref _shockValue, value);
		}

		[Ordinal(5)] 
		[RED("sadValue")] 
		public CFloat SadValue
		{
			get => GetProperty(ref _sadValue);
			set => SetProperty(ref _sadValue, value);
		}

		[Ordinal(6)] 
		[RED("joyValue")] 
		public CFloat JoyValue
		{
			get => GetProperty(ref _joyValue);
			set => SetProperty(ref _joyValue, value);
		}

		[Ordinal(7)] 
		[RED("surpriseValue")] 
		public CFloat SurpriseValue
		{
			get => GetProperty(ref _surpriseValue);
			set => SetProperty(ref _surpriseValue, value);
		}

		[Ordinal(8)] 
		[RED("disgustValue")] 
		public CFloat DisgustValue
		{
			get => GetProperty(ref _disgustValue);
			set => SetProperty(ref _disgustValue, value);
		}

		[Ordinal(9)] 
		[RED("aggressiveValue")] 
		public CFloat AggressiveValue
		{
			get => GetProperty(ref _aggressiveValue);
			set => SetProperty(ref _aggressiveValue, value);
		}

		[Ordinal(10)] 
		[RED("funnyValue")] 
		public CFloat FunnyValue
		{
			get => GetProperty(ref _funnyValue);
			set => SetProperty(ref _funnyValue, value);
		}

		[Ordinal(11)] 
		[RED("curiosityValue")] 
		public CFloat CuriosityValue
		{
			get => GetProperty(ref _curiosityValue);
			set => SetProperty(ref _curiosityValue, value);
		}

		[Ordinal(12)] 
		[RED("stimPriority")] 
		public CInt32 StimPriority
		{
			get => GetProperty(ref _stimPriority);
			set => SetProperty(ref _stimPriority, value);
		}

		public senseStimuliData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
