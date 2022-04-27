using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class activityLogEntryLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("available")] 
		public CBool Available
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("originalSize")] 
		public CUInt16 OriginalSize
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(3)] 
		[RED("size")] 
		public CUInt16 Size
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(4)] 
		[RED("displayText")] 
		public CString DisplayText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("root")] 
		public CWeakHandle<inkTextWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(6)] 
		[RED("appearingAnim")] 
		public CHandle<inkanimController> AppearingAnim
		{
			get => GetPropertyValue<CHandle<inkanimController>>();
			set => SetPropertyValue<CHandle<inkanimController>>(value);
		}

		[Ordinal(7)] 
		[RED("typingAnim")] 
		public CHandle<inkanimController> TypingAnim
		{
			get => GetPropertyValue<CHandle<inkanimController>>();
			set => SetPropertyValue<CHandle<inkanimController>>(value);
		}

		[Ordinal(8)] 
		[RED("disappearingAnim")] 
		public CHandle<inkanimController> DisappearingAnim
		{
			get => GetPropertyValue<CHandle<inkanimController>>();
			set => SetPropertyValue<CHandle<inkanimController>>(value);
		}

		[Ordinal(9)] 
		[RED("typingAnimDef")] 
		public CHandle<inkanimDefinition> TypingAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(10)] 
		[RED("typingAnimProxy")] 
		public CHandle<inkanimProxy> TypingAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(11)] 
		[RED("disappearingAnimDef")] 
		public CHandle<inkanimDefinition> DisappearingAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(12)] 
		[RED("disappearingAnimProxy")] 
		public CHandle<inkanimProxy> DisappearingAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public activityLogEntryLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
