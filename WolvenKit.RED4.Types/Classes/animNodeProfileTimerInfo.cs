using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animNodeProfileTimerInfo : RedBaseClass
	{
		private CName _name;
		private CEnum<animNodeProfileTimerMode> _mode;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<animNodeProfileTimerMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		public animNodeProfileTimerInfo()
		{
			_mode = new() { Value = Enums.animNodeProfileTimerMode.End };
		}
	}
}
