using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionPoliceSecuritySystemRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("securitySystemID")] 
		public gamePersistentID SecuritySystemID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		public PreventionPoliceSecuritySystemRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
