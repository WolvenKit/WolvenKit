using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StopVFXEffector : gameEffector
	{
		private CName _vfxName;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("vfxName")] 
		public CName VfxName
		{
			get => GetProperty(ref _vfxName);
			set => SetProperty(ref _vfxName, value);
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
