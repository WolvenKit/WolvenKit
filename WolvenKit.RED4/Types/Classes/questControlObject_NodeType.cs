using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questControlObject_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questControlObject_NodeType()
		{
			ObjectRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
