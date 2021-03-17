using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleBulletGeneric : BaseProjectile
	{
		private CHandle<entIComponent> _meshComponent;
		private CHandle<gameEffectInstance> _damage;
		private CFloat _countTime;
		private CFloat _startVelocity;
		private CFloat _lifetime_472;
		private CBool _alive;

		[Ordinal(51)] 
		[RED("meshComponent")] 
		public CHandle<entIComponent> MeshComponent
		{
			get => GetProperty(ref _meshComponent);
			set => SetProperty(ref _meshComponent, value);
		}

		[Ordinal(52)] 
		[RED("damage")] 
		public CHandle<gameEffectInstance> Damage
		{
			get => GetProperty(ref _damage);
			set => SetProperty(ref _damage, value);
		}

		[Ordinal(53)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get => GetProperty(ref _countTime);
			set => SetProperty(ref _countTime, value);
		}

		[Ordinal(54)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetProperty(ref _startVelocity);
			set => SetProperty(ref _startVelocity, value);
		}

		[Ordinal(55)] 
		[RED("lifetime")] 
		public CFloat Lifetime_472
		{
			get => GetProperty(ref _lifetime_472);
			set => SetProperty(ref _lifetime_472, value);
		}

		[Ordinal(56)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}

		public sampleBulletGeneric(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
