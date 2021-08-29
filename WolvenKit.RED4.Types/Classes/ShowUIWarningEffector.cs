using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShowUIWarningEffector : gameEffector
	{
		private CFloat _duration;
		private CString _primaryText;
		private CString _secondaryText;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(1)] 
		[RED("primaryText")] 
		public CString PrimaryText
		{
			get => GetProperty(ref _primaryText);
			set => SetProperty(ref _primaryText, value);
		}

		[Ordinal(2)] 
		[RED("secondaryText")] 
		public CString SecondaryText
		{
			get => GetProperty(ref _secondaryText);
			set => SetProperty(ref _secondaryText, value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
