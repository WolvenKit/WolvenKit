using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleFactEffector : gameEffector
	{
		private CName _fact;
		private CInt32 _valueOn;
		private CInt32 _valueOff;

		[Ordinal(0)] 
		[RED("fact")] 
		public CName Fact
		{
			get => GetProperty(ref _fact);
			set => SetProperty(ref _fact, value);
		}

		[Ordinal(1)] 
		[RED("valueOn")] 
		public CInt32 ValueOn
		{
			get => GetProperty(ref _valueOn);
			set => SetProperty(ref _valueOn, value);
		}

		[Ordinal(2)] 
		[RED("valueOff")] 
		public CInt32 ValueOff
		{
			get => GetProperty(ref _valueOff);
			set => SetProperty(ref _valueOff, value);
		}
	}
}
