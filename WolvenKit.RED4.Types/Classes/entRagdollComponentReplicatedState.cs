using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRagdollComponentReplicatedState : netIComponentState
	{
		private CArray<Transform> _transforms;
		private CBool _isSleeping;

		[Ordinal(2)] 
		[RED("transforms")] 
		public CArray<Transform> Transforms
		{
			get => GetProperty(ref _transforms);
			set => SetProperty(ref _transforms, value);
		}

		[Ordinal(3)] 
		[RED("isSleeping")] 
		public CBool IsSleeping
		{
			get => GetProperty(ref _isSleeping);
			set => SetProperty(ref _isSleeping, value);
		}
	}
}
