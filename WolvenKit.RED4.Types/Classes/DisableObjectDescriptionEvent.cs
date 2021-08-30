using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisableObjectDescriptionEvent : redEvent
	{
		private CBool _isDisabled;

		[Ordinal(0)] 
		[RED("isDisabled")] 
		public CBool IsDisabled
		{
			get => GetProperty(ref _isDisabled);
			set => SetProperty(ref _isDisabled, value);
		}

		public DisableObjectDescriptionEvent()
		{
			_isDisabled = true;
		}
	}
}
