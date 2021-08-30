using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNarrationPlateComponent : entIComponent
	{
		private CName _narrationCaption;
		private CName _narrationText;
		private CBool _isEnabled;

		[Ordinal(3)] 
		[RED("narrationCaption")] 
		public CName NarrationCaption
		{
			get => GetProperty(ref _narrationCaption);
			set => SetProperty(ref _narrationCaption, value);
		}

		[Ordinal(4)] 
		[RED("narrationText")] 
		public CName NarrationText
		{
			get => GetProperty(ref _narrationText);
			set => SetProperty(ref _narrationText, value);
		}

		[Ordinal(5)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public gameNarrationPlateComponent()
		{
			_isEnabled = true;
		}
	}
}
