using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScreenMessageData : IScriptable
	{
		[Ordinal(0)] 
		[RED("messageRecord")] 
		public CHandle<gamedataScreenMessageData_Record> MessageRecord
		{
			get => GetPropertyValue<CHandle<gamedataScreenMessageData_Record>>();
			set => SetPropertyValue<CHandle<gamedataScreenMessageData_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ScreenMessageData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
