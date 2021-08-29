using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StopAndPlayVFXEffector : gameEffector
	{
		private CName _vfxToStop;
		private CName _vfxToStart;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("vfxToStop")] 
		public CName VfxToStop
		{
			get => GetProperty(ref _vfxToStop);
			set => SetProperty(ref _vfxToStop, value);
		}

		[Ordinal(1)] 
		[RED("vfxToStart")] 
		public CName VfxToStart
		{
			get => GetProperty(ref _vfxToStart);
			set => SetProperty(ref _vfxToStart, value);
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
