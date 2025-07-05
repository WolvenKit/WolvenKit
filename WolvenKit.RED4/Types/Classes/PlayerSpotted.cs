using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerSpotted : redEvent
	{
		[Ordinal(0)] 
		[RED("comesFromNPC")] 
		public CBool ComesFromNPC
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public gamePersistentID OwnerID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(2)] 
		[RED("doesSee")] 
		public CBool DoesSee
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("agentAreas")] 
		public CArray<CHandle<SecurityAreaControllerPS>> AgentAreas
		{
			get => GetPropertyValue<CArray<CHandle<SecurityAreaControllerPS>>>();
			set => SetPropertyValue<CArray<CHandle<SecurityAreaControllerPS>>>(value);
		}

		public PlayerSpotted()
		{
			OwnerID = new gamePersistentID();
			AgentAreas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
