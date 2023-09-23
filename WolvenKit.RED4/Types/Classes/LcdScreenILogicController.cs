using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LcdScreenILogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("defaultUI")] 
		public inkWidgetReference DefaultUI
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("mainDisplayWidget")] 
		public inkVideoWidgetReference MainDisplayWidget
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("messegeWidget")] 
		public inkTextWidgetReference MessegeWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("backgroundWidget")] 
		public inkImageWidgetReference BackgroundWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("messegeRecord")] 
		public CWeakHandle<gamedataScreenMessageData_Record> MessegeRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataScreenMessageData_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataScreenMessageData_Record>>(value);
		}

		[Ordinal(6)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public LcdScreenILogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
