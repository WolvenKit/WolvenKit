using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAttachmentSlots : entIComponent
	{
		[Ordinal(3)] 
		[RED("animParams")] 
		public CArray<gameAnimParamSlotsOption> AnimParams
		{
			get => GetPropertyValue<CArray<gameAnimParamSlotsOption>>();
			set => SetPropertyValue<CArray<gameAnimParamSlotsOption>>(value);
		}

		public gameAttachmentSlots()
		{
			Name = "Component";
			AnimParams = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
