using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeArcadeColliderData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameuiarcadeArcadeColliderType> Type
		{
			get => GetPropertyValue<CEnum<gameuiarcadeArcadeColliderType>>();
			set => SetPropertyValue<CEnum<gameuiarcadeArcadeColliderType>>(value);
		}

		[Ordinal(1)] 
		[RED("shape")] 
		public CHandle<gameuiarcadeBoundingShape> Shape
		{
			get => GetPropertyValue<CHandle<gameuiarcadeBoundingShape>>();
			set => SetPropertyValue<CHandle<gameuiarcadeBoundingShape>>(value);
		}

		public gameuiarcadeArcadeColliderData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
