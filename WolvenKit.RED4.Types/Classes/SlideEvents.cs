using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SlideEvents : CrouchEvents
	{
		private CBool _rumblePlayed;
		private CHandle<gameStatModifierData_Deprecated> _addDecelerationModifier;

		[Ordinal(3)] 
		[RED("rumblePlayed")] 
		public CBool RumblePlayed
		{
			get => GetProperty(ref _rumblePlayed);
			set => SetProperty(ref _rumblePlayed, value);
		}

		[Ordinal(4)] 
		[RED("addDecelerationModifier")] 
		public CHandle<gameStatModifierData_Deprecated> AddDecelerationModifier
		{
			get => GetProperty(ref _addDecelerationModifier);
			set => SetProperty(ref _addDecelerationModifier, value);
		}
	}
}
