using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerManageBinkComponent_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("videoPath")] 
		public CString VideoPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("action")] 
		public CEnum<gameBinkVideoAction> Action
		{
			get => GetPropertyValue<CEnum<gameBinkVideoAction>>();
			set => SetPropertyValue<CEnum<gameBinkVideoAction>>(value);
		}

		public questEntityManagerManageBinkComponent_NodeTypeParams()
		{
			ObjectRef = new() { Names = new() };
			Action = Enums.gameBinkVideoAction.Start;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
