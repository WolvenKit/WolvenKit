using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayVFXEffector : gameEffector
	{
		private CName _vfxName;
		private CBool _startOnUninitialize;
		private CBool _fireAndForget;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("vfxName")] 
		public CName VfxName
		{
			get => GetProperty(ref _vfxName);
			set => SetProperty(ref _vfxName, value);
		}

		[Ordinal(1)] 
		[RED("startOnUninitialize")] 
		public CBool StartOnUninitialize
		{
			get => GetProperty(ref _startOnUninitialize);
			set => SetProperty(ref _startOnUninitialize, value);
		}

		[Ordinal(2)] 
		[RED("fireAndForget")] 
		public CBool FireAndForget
		{
			get => GetProperty(ref _fireAndForget);
			set => SetProperty(ref _fireAndForget, value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
