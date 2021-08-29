using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioeventsSoundSwitch : redEvent
	{
		private CName _switchName;
		private CName _switchValue;

		[Ordinal(0)] 
		[RED("switchName")] 
		public CName SwitchName
		{
			get => GetProperty(ref _switchName);
			set => SetProperty(ref _switchName, value);
		}

		[Ordinal(1)] 
		[RED("switchValue")] 
		public CName SwitchValue
		{
			get => GetProperty(ref _switchValue);
			set => SetProperty(ref _switchValue, value);
		}
	}
}
