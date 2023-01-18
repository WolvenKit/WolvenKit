using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetFocusClueState_NodeType : questIVisionModeNodeType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("clueId")] 
		public CInt32 ClueId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("clueState")] 
		public CBool ClueState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSetFocusClueState_NodeType()
		{
			ObjectRef = new() { Names = new() };
			ClueId = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
