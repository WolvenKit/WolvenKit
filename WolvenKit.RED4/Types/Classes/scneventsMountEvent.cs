using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsMountEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("parent")] 
		public scnPerformerId Parent
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(7)] 
		[RED("child")] 
		public scnPerformerId Child
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(8)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("carryStyle")] 
		public CEnum<gamePSMBodyCarryingStyle> CarryStyle
		{
			get => GetPropertyValue<CEnum<gamePSMBodyCarryingStyle>>();
			set => SetPropertyValue<CEnum<gamePSMBodyCarryingStyle>>(value);
		}

		[Ordinal(10)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("removePitchRollRotationOnDismount")] 
		public CBool RemovePitchRollRotationOnDismount
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("keepTransform")] 
		public CBool KeepTransform
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("isCarrying")] 
		public CBool IsCarrying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("switchRenderPlane")] 
		public CBool SwitchRenderPlane
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scneventsMountEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			Parent = new scnPerformerId { Id = 4294967040 };
			Child = new scnPerformerId { Id = 4294967040 };
			IsInstant = true;
			SwitchRenderPlane = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
