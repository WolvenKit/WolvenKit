using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileSpawnerAttachExistingEvent : redEvent
	{
		private CWeakHandle<gameObject> _projectile;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("projectile")] 
		public CWeakHandle<gameObject> Projectile
		{
			get => GetProperty(ref _projectile);
			set => SetProperty(ref _projectile, value);
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
