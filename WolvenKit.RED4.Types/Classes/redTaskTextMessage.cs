using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class redTaskTextMessage : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("taskId")] 
		public CUInt32 TaskId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<redTaskTextMessageType> Type
		{
			get => GetPropertyValue<CEnum<redTaskTextMessageType>>();
			set => SetPropertyValue<CEnum<redTaskTextMessageType>>(value);
		}

		public redTaskTextMessage()
		{
			TaskId = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
