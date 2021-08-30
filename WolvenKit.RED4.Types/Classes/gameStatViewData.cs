using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatViewData : RedBaseClass
	{
		private CEnum<gamedataStatType> _type;
		private CString _statName;
		private CInt32 _value;
		private CInt32 _diffValue;
		private CBool _isMaxValue;
		private CFloat _valueF;
		private CFloat _diffValueF;
		private CFloat _statMinValueF;
		private CFloat _statMaxValueF;
		private CBool _canBeCompared;
		private CBool _isCompared;
		private CInt32 _statMinValue;
		private CInt32 _statMaxValue;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataStatType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("statName")] 
		public CString StatName
		{
			get => GetProperty(ref _statName);
			set => SetProperty(ref _statName, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(3)] 
		[RED("diffValue")] 
		public CInt32 DiffValue
		{
			get => GetProperty(ref _diffValue);
			set => SetProperty(ref _diffValue, value);
		}

		[Ordinal(4)] 
		[RED("isMaxValue")] 
		public CBool IsMaxValue
		{
			get => GetProperty(ref _isMaxValue);
			set => SetProperty(ref _isMaxValue, value);
		}

		[Ordinal(5)] 
		[RED("valueF")] 
		public CFloat ValueF
		{
			get => GetProperty(ref _valueF);
			set => SetProperty(ref _valueF, value);
		}

		[Ordinal(6)] 
		[RED("diffValueF")] 
		public CFloat DiffValueF
		{
			get => GetProperty(ref _diffValueF);
			set => SetProperty(ref _diffValueF, value);
		}

		[Ordinal(7)] 
		[RED("statMinValueF")] 
		public CFloat StatMinValueF
		{
			get => GetProperty(ref _statMinValueF);
			set => SetProperty(ref _statMinValueF, value);
		}

		[Ordinal(8)] 
		[RED("statMaxValueF")] 
		public CFloat StatMaxValueF
		{
			get => GetProperty(ref _statMaxValueF);
			set => SetProperty(ref _statMaxValueF, value);
		}

		[Ordinal(9)] 
		[RED("canBeCompared")] 
		public CBool CanBeCompared
		{
			get => GetProperty(ref _canBeCompared);
			set => SetProperty(ref _canBeCompared, value);
		}

		[Ordinal(10)] 
		[RED("isCompared")] 
		public CBool IsCompared
		{
			get => GetProperty(ref _isCompared);
			set => SetProperty(ref _isCompared, value);
		}

		[Ordinal(11)] 
		[RED("statMinValue")] 
		public CInt32 StatMinValue
		{
			get => GetProperty(ref _statMinValue);
			set => SetProperty(ref _statMinValue, value);
		}

		[Ordinal(12)] 
		[RED("statMaxValue")] 
		public CInt32 StatMaxValue
		{
			get => GetProperty(ref _statMaxValue);
			set => SetProperty(ref _statMaxValue, value);
		}

		public gameStatViewData()
		{
			_type = new() { Value = Enums.gamedataStatType.Invalid };
		}
	}
}
