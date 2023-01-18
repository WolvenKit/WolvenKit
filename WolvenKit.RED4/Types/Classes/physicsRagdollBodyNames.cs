using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsRagdollBodyNames : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ParentAnimName")] 
		public CName ParentAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("ChildAnimName")] 
		public CName ChildAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public physicsRagdollBodyNames()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
