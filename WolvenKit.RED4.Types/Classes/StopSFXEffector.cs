using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StopSFXEffector : gameEffector
	{
		private CName _sfxName;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("sfxName")] 
		public CName SfxName
		{
			get => GetProperty(ref _sfxName);
			set => SetProperty(ref _sfxName, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
