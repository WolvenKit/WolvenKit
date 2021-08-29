using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConstantStatPoolPrereqState : StatPoolPrereqState
	{
		private CBool _listenConstantly;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(1)] 
		[RED("listenConstantly")] 
		public CBool ListenConstantly
		{
			get => GetProperty(ref _listenConstantly);
			set => SetProperty(ref _listenConstantly, value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
