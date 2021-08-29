using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameWeakspotComponentReplicatedState : netIComponentState
	{
		private CArray<gameWeakSpotReplicatedInfo> _weakspotRepInfos;

		[Ordinal(2)] 
		[RED("WeakspotRepInfos")] 
		public CArray<gameWeakSpotReplicatedInfo> WeakspotRepInfos
		{
			get => GetProperty(ref _weakspotRepInfos);
			set => SetProperty(ref _weakspotRepInfos, value);
		}
	}
}
