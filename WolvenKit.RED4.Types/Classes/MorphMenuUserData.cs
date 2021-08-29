using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MorphMenuUserData : IScriptable
	{
		private CBool _optionsListInitialized;

		[Ordinal(0)] 
		[RED("optionsListInitialized")] 
		public CBool OptionsListInitialized
		{
			get => GetProperty(ref _optionsListInitialized);
			set => SetProperty(ref _optionsListInitialized, value);
		}
	}
}
