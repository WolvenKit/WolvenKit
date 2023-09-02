using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SasquatchComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("owner")] 
		public CWeakHandle<NPCPuppet> Owner
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(6)] 
		[RED("owner_id")] 
		public entEntityID Owner_id
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public SasquatchComponent()
		{
			Owner_id = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
