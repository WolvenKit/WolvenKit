using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioSceneVariableWriteActionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public CEnum<audioNumberOperation> Operation
		{
			get => GetPropertyValue<CEnum<audioNumberOperation>>();
			set => SetPropertyValue<CEnum<audioNumberOperation>>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public audioAudioSceneVariableWriteActionData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
