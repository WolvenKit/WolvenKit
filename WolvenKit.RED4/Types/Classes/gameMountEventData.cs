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
		[RED("initialTransformLS")] 
		public Transform InitialTransformLS
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(5)] 
		[RED("setEntityVisibleWhenMountFinish")] 
		public CBool SetEntityVisibleWhenMountFinish
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("removePitchRollRotationOnDismount")] 
		public CBool RemovePitchRollRotationOnDismount
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("ignoreHLS")] 
		public CBool IgnoreHLS
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("mountEventOptions")] 
		public CHandle<gameMountEventOptions> MountEventOptions
		{
			get => GetPropertyValue<CHandle<gameMountEventOptions>>();
			set => SetPropertyValue<CHandle<gameMountEventOptions>>(value);
		}

		public gameMountEventData()
		{
			MountParentEntityId = new();
			InitialTransformLS = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			RemovePitchRollRotationOnDismount = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
