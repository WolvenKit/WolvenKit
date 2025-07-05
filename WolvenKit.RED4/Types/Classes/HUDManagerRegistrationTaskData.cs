using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HUDManagerRegistrationTaskData : gameScriptTaskData
	{
		[Ordinal(0)] 
		[RED("shouldRegister")] 
		public CBool ShouldRegister
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HUDManagerRegistrationTaskData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
