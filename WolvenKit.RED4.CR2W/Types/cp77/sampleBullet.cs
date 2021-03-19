using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleBullet : BaseProjectile
	{
		private CHandle<entIComponent> _meshComponent;
		private CFloat _countTime;
		private CFloat _startVelocity;
		private CFloat _lifetime_456;
		private CHandle<BulletCollisionEvaluator> _bulletCollisionEvaluator;
		private CBool _alive;

		[Ordinal(51)] 
		[RED("meshComponent")] 
		public CHandle<entIComponent> MeshComponent
		{
			get => GetProperty(ref _meshComponent);
			set => SetProperty(ref _meshComponent, value);
		}

		[Ordinal(52)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get => GetProperty(ref _countTime);
			set => SetProperty(ref _countTime, value);
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
		public CFloat Lifetime_456
		{
			get => GetProperty(ref _lifetime_456);
			set => SetProperty(ref _lifetime_456, value);
		}

		[Ordinal(55)] 
		[RED("BulletCollisionEvaluator")] 
		public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator
		{
			get => GetProperty(ref _bulletCollisionEvaluator);
			set => SetProperty(ref _bulletCollisionEvaluator, value);
		}

		[Ordinal(56)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}

		public sampleBullet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
