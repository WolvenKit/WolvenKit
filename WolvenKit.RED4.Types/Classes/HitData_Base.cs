using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitData_Base : gameHitShapeUserData
	{
		[Ordinal(0)] 
		[RED("hitShapeTag")] 
		public CName HitShapeTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("bodyPartStatPoolName")] 
		public CName BodyPartStatPoolName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("hitShapeType")] 
		public CEnum<HitShape_Type> HitShapeType
		{
			get => GetPropertyValue<CEnum<HitShape_Type>>();
			set => SetPropertyValue<CEnum<HitShape_Type>>(value);
		}

		public HitData_Base()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
