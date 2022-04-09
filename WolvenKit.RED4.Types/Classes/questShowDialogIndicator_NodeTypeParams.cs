using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questShowDialogIndicator_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
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

		public questShowDialogIndicator_NodeTypeParams()
		{
			ObjectRef = new() { Names = new() };
			Show = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
