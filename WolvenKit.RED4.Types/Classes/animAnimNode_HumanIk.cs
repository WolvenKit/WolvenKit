using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_HumanIk : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("ikTargetsControllers")] 
		public CArray<animTEMP_IKTargetsControllerBodyType> IkTargetsControllers
		{
			get => GetPropertyValue<CArray<animTEMP_IKTargetsControllerBodyType>>();
			set => SetPropertyValue<CArray<animTEMP_IKTargetsControllerBodyType>>(value);
		}

		public animAnimNode_HumanIk()
		{
			Id = 4294967295;
			InputLink = new();
			IkTargetsControllers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
