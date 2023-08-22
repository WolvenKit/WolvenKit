using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameShapeData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("result")] 
		public gameHitResult Result
		{
			get => GetPropertyValue<gameHitResult>();
			set => SetPropertyValue<gameHitResult>(value);
		}

		[Ordinal(1)] 
		[RED("userData")] 
		public CHandle<gameHitShapeUserData> UserData
		{
			get => GetPropertyValue<CHandle<gameHitShapeUserData>>();
			set => SetPropertyValue<CHandle<gameHitShapeUserData>>(value);
		}

		[Ordinal(2)] 
		[RED("physicsMaterial")] 
		public CName PhysicsMaterial
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("hitShapeName")] 
		public CName HitShapeName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameShapeData()
		{
			Result = new gameHitResult { HitPositionEnter = new Vector4(), HitPositionExit = new Vector4() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
