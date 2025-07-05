using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCommunityID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public gameCommunityID()
		{
			EntityId = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
