using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionSecurityAreaRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("playerIsIn")] 
		public CBool PlayerIsIn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("areaID")] 
		public gamePersistentID AreaID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		public PreventionSecurityAreaRequest()
		{
			AreaID = new gamePersistentID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
