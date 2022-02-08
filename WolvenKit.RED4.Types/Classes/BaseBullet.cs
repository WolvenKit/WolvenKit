using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseBullet : BaseProjectile
	{
		[Ordinal(51)] 
		[RED("meshComponent")] 
		public CHandle<entIComponent> MeshComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(52)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("lifetime")] 
		public CFloat Lifetime_440
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BaseBullet()
		{
			Alive = true;
		}
	}
}
