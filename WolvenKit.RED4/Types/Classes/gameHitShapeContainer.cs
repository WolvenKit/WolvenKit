using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitShapeContainer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(3)] 
		[RED("shape")] 
		public CHandle<gameIHitShape> Shape
		{
			get => GetPropertyValue<CHandle<gameIHitShape>>();
			set => SetPropertyValue<CHandle<gameIHitShape>>(value);
		}

		[Ordinal(4)] 
		[RED("userData")] 
		public CHandle<gameHitShapeUserData> UserData
		{
			get => GetPropertyValue<CHandle<gameHitShapeUserData>>();
			set => SetPropertyValue<CHandle<gameHitShapeUserData>>(value);
		}

		[Ordinal(5)] 
		[RED("physicsMaterial")] 
		public physicsMaterialReference PhysicsMaterial
		{
			get => GetPropertyValue<physicsMaterialReference>();
			set => SetPropertyValue<physicsMaterialReference>(value);
		}

		public gameHitShapeContainer()
		{
			Color = new CColor();
			PhysicsMaterial = new physicsMaterialReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
