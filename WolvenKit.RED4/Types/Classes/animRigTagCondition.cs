using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animRigTagCondition : animIStaticCondition
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animRigTagCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
