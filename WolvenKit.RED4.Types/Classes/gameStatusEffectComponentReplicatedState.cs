using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatusEffectComponentReplicatedState : netIComponentState
	{
		private CArray<gameStatusEffectReplicatedInfo> _replicatedInfo;

		[Ordinal(2)] 
		[RED("replicatedInfo")] 
		public CArray<gameStatusEffectReplicatedInfo> ReplicatedInfo
		{
			get => GetProperty(ref _replicatedInfo);
			set => SetProperty(ref _replicatedInfo, value);
		}
	}
}
