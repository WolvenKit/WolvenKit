using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetRandomIntArgument : AIRandomTasks
	{
		private CInt32 _maxValue;
		private CInt32 _minValue;
		private CName _argumentName;

		[Ordinal(0)] 
		[RED("MaxValue")] 
		public CInt32 MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(1)] 
		[RED("MinValue")] 
		public CInt32 MinValue
		{
			get => GetProperty(ref _minValue);
			set => SetProperty(ref _minValue, value);
		}

		[Ordinal(2)] 
		[RED("ArgumentName")] 
		public CName ArgumentName
		{
			get => GetProperty(ref _argumentName);
			set => SetProperty(ref _argumentName, value);
		}
	}
}
