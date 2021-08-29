using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedeviceAction : redEvent
	{
		private CName _actionName;
		private CInt32 _clearanceLevel;
		private CString _localizedObjectName;

		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		[Ordinal(1)] 
		[RED("clearanceLevel")] 
		public CInt32 ClearanceLevel
		{
			get => GetProperty(ref _clearanceLevel);
			set => SetProperty(ref _clearanceLevel, value);
		}

		[Ordinal(2)] 
		[RED("localizedObjectName")] 
		public CString LocalizedObjectName
		{
			get => GetProperty(ref _localizedObjectName);
			set => SetProperty(ref _localizedObjectName, value);
		}
	}
}
