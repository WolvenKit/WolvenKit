using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DialogueChoiceHubPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("isChoiceHubActive")] 
		public CBool IsChoiceHubActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
