using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseVisibleObject : IScriptable
	{
		[Ordinal(0)] 
		[RED("description")] 
		public CName Description
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("visibilityDistance")] 
		public CFloat VisibilityDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("visibleObjectType")] 
		public CEnum<gamedataSenseObjectType> VisibleObjectType
		{
			get => GetPropertyValue<CEnum<gamedataSenseObjectType>>();
			set => SetPropertyValue<CEnum<gamedataSenseObjectType>>(value);
		}

		public senseVisibleObject()
		{
			VisibilityDistance = 100.000000F;
			VisibleObjectType = Enums.gamedataSenseObjectType.Undefined;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
