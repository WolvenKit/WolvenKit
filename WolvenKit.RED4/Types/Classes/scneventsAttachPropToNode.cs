using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsAttachPropToNode : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get => GetPropertyValue<scnPropId>();
			set => SetPropertyValue<scnPropId>(value);
		}

		[Ordinal(7)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(8)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(9)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public scneventsAttachPropToNode()
		{
			Id = new() { Id = 18446744073709551615 };
			PropId = new() { Id = 4294967295 };
			CustomOffsetPos = new();
			CustomOffsetRot = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
