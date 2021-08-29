using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StopAndPlaySFXEffector : gameEffector
	{
		private CName _sfxToStop;
		private CName _sfxToStart;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("sfxToStop")] 
		public CName SfxToStop
		{
			get => GetProperty(ref _sfxToStop);
			set => SetProperty(ref _sfxToStop, value);
		}

		[Ordinal(1)] 
		[RED("sfxToStart")] 
		public CName SfxToStart
		{
			get => GetProperty(ref _sfxToStart);
			set => SetProperty(ref _sfxToStart, value);
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
