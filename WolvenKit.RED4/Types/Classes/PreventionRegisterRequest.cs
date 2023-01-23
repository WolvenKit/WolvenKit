using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionRegisterRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("requester")] 
		public CHandle<gamePersistentState> Requester
		{
			get => GetPropertyValue<CHandle<gamePersistentState>>();
			set => SetPropertyValue<CHandle<gamePersistentState>>(value);
		}

		[Ordinal(1)] 
		[RED("attitudeGroup")] 
		public CName AttitudeGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PreventionRegisterRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
