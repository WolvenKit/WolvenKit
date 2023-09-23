using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterBullet : gameuiarcadeShooterObjectController
	{
		[Ordinal(3)] 
		[RED("customBoundSize")] 
		public CBool CustomBoundSize
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("boundSize")] 
		public Vector2 BoundSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public gameuiarcadeShooterBullet()
		{
			BoundSize = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
