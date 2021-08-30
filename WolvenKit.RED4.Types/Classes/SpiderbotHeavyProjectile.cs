using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpiderbotHeavyProjectile : BaseProjectile
	{
		private CHandle<entIComponent> _meshComponent;
		private gameEffectRef _effect;
		private CFloat _startVelocity;
		private CFloat _lifetime_476;
		private CBool _alive;
		private CBool _hit;

		[Ordinal(51)] 
		[RED("meshComponent")] 
		public CHandle<entIComponent> MeshComponent
		{
			get => GetProperty(ref _meshComponent);
			set => SetProperty(ref _meshComponent, value);
		}

		[Ordinal(52)] 
		[RED("effect")] 
		public gameEffectRef Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(53)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetProperty(ref _startVelocity);
			set => SetProperty(ref _startVelocity, value);
		}

		[Ordinal(54)] 
		[RED("lifetime")] 
		public CFloat Lifetime_476
		{
			get => GetProperty(ref _lifetime_476);
			set => SetProperty(ref _lifetime_476, value);
		}

		[Ordinal(55)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}

		[Ordinal(56)] 
		[RED("hit")] 
		public CBool Hit
		{
			get => GetProperty(ref _hit);
			set => SetProperty(ref _hit, value);
		}

		public SpiderbotHeavyProjectile()
		{
			_alive = true;
		}
	}
}
