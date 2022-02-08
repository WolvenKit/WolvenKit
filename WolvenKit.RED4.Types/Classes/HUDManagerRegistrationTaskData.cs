using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HUDManagerRegistrationTaskData : gameScriptTaskData
	{
		[Ordinal(0)] 
		[RED("shouldRegister")] 
		public CBool ShouldRegister
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
