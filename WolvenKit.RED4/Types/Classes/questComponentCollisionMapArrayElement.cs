using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questComponentCollisionMapArrayElement : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("componentNameKey")] 
		public CName ComponentNameKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("enableCollision")] 
		public CBool EnableCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("enableQueries")] 
		public CBool EnableQueries
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questComponentCollisionMapArrayElement()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
