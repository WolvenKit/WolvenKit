using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmartBulletDeflectedEvent : redEvent
	{
		private CMatrix _localToWorld;
		private CWeakHandle<gameObject> _instigator;
		private CWeakHandle<gameObject> _weapon;

		[Ordinal(0)] 
		[RED("localToWorld")] 
		public CMatrix LocalToWorld
		{
			get => GetProperty(ref _localToWorld);
			set => SetProperty(ref _localToWorld, value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(2)] 
		[RED("weapon")] 
		public CWeakHandle<gameObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}
	}
}
