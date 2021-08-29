using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DialogueChoiceHubPrereq : gameIScriptablePrereq
	{
		private CBool _isChoiceHubActive;

		[Ordinal(0)] 
		[RED("isChoiceHubActive")] 
		public CBool IsChoiceHubActive
		{
			get => GetProperty(ref _isChoiceHubActive);
			set => SetProperty(ref _isChoiceHubActive, value);
		}
	}
}
