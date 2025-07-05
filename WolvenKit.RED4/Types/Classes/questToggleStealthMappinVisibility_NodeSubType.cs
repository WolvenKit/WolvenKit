using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questToggleStealthMappinVisibility_NodeSubType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questToggleStealthMappinVisibility_NodeSubType()
		{
			EntityReference = new gameEntityReference { Names = new() };
			Show = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
