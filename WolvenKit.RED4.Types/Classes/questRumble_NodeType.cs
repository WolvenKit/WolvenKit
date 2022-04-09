using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRumble_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		[Ordinal(0)] 
		[RED("rumbleEvent")] 
		public CName RumbleEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questRumble_NodeType()
		{
			ObjectRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
