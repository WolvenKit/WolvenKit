using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMountEventData : IScriptable
	{
		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("mountParentEntityId")] 
		public entEntityID MountParentEntityId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("entryAnimName")] 
		public CName EntryAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("entrySlotName")] 
		public CName EntrySlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("initialTransformLS")] 
		public Transform InitialTransformLS
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(6)] 
		[RED("setEntityVisibleWhenMountFinish")] 
		public CBool SetEntityVisibleWhenMountFinish
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("removePitchRollRotationOnDismount")] 
		public CBool RemovePitchRollRotationOnDismount
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("ignoreHLS")] 
		public CBool IgnoreHLS
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("switchRenderPlane")] 
		public CBool SwitchRenderPlane
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("isJustAttached")] 
		public CBool IsJustAttached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("isCarrying")] 
		public CBool IsCarrying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("allowFailsafeTeleport")] 
		public CBool AllowFailsafeTeleport
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("mountEventOptions")] 
		public CHandle<gameMountEventOptions> MountEventOptions
		{
			get => GetPropertyValue<CHandle<gameMountEventOptions>>();
			set => SetPropertyValue<CHandle<gameMountEventOptions>>(value);
		}

		public gameMountEventData()
		{
			MountParentEntityId = new entEntityID();
			EntrySlotName = "default";
			InitialTransformLS = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			RemovePitchRollRotationOnDismount = true;
			SwitchRenderPlane = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
