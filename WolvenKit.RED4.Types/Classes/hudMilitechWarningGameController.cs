using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class hudMilitechWarningGameController : gameuiHUDGameController
	{
		private CWeakHandle<inkCompoundWidget> _root;
		private CHandle<inkanimProxy> _anim;
		private CUInt32 _factListenerId;

		[Ordinal(9)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(10)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetProperty(ref _anim);
			set => SetProperty(ref _anim, value);
		}

		[Ordinal(11)] 
		[RED("factListenerId")] 
		public CUInt32 FactListenerId
		{
			get => GetProperty(ref _factListenerId);
			set => SetProperty(ref _factListenerId, value);
		}
	}
}
