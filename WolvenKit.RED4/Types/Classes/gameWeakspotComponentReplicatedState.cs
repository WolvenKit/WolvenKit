using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameWeakspotComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] 
		[RED("WeakspotRepInfos")] 
		public CArray<gameWeakSpotReplicatedInfo> WeakspotRepInfos
		{
			get => GetPropertyValue<CArray<gameWeakSpotReplicatedInfo>>();
			set => SetPropertyValue<CArray<gameWeakSpotReplicatedInfo>>(value);
		}

		public gameWeakspotComponentReplicatedState()
		{
			Enabled = true;
			WeakspotRepInfos = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
