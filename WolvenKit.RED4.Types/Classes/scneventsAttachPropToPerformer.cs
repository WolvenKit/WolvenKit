using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsAttachPropToPerformer : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get => GetPropertyValue<scnPropId>();
			set => SetPropertyValue<scnPropId>(value);
		}

		[Ordinal(7)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(8)] 
		[RED("slot")] 
		public CName Slot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("offsetMode")] 
		public CEnum<scnOffsetMode> OffsetMode
		{
			get => GetPropertyValue<CEnum<scnOffsetMode>>();
			set => SetPropertyValue<CEnum<scnOffsetMode>>(value);
		}

		[Ordinal(10)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(11)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public scneventsAttachPropToPerformer()
		{
			Id = new() { Id = 18446744073709551615 };
			PropId = new() { Id = 4294967295 };
			PerformerId = new() { Id = 4294967040 };
			Slot = "(Root)";
			CustomOffsetPos = new();
			CustomOffsetRot = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
