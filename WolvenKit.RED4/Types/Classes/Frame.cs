using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Frame : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("isLinkedToPower")] 
		public CBool IsLinkedToPower
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(99)] 
		[RED("smartFrameName")] 
		public CString SmartFrameName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(100)] 
		[RED("smartFrameDescriptionLocKey")] 
		public CString SmartFrameDescriptionLocKey
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(101)] 
		[RED("systemHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(102)] 
		[RED("squatFactToken")] 
		public CUInt32 SquatFactToken
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(103)] 
		[RED("questFactToken")] 
		public CUInt32 QuestFactToken
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(104)] 
		[RED("powerFactToken")] 
		public CUInt32 PowerFactToken
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(105)] 
		[RED("activePhotoID")] 
		public CInt32 ActivePhotoID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(106)] 
		[RED("activePhotoHash")] 
		public CUInt32 ActivePhotoHash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(107)] 
		[RED("activePhotoUV")] 
		public RectF ActivePhotoUV
		{
			get => GetPropertyValue<RectF>();
			set => SetPropertyValue<RectF>(value);
		}

		[Ordinal(108)] 
		[RED("frameSwitcherToken")] 
		public CHandle<inkGameNotificationToken> FrameSwitcherToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		public Frame()
		{
			ControllerTypeName = "FrameController";
			SmartFrameName = "SMARTFRAMES™";
			SmartFrameDescriptionLocKey = "UI-SmartFrames-Description";
			ActivePhotoUV = new RectF();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
