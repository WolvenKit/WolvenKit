using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BaseSwitch : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("timeWarpingEnabled")] 
		public CBool TimeWarpingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetPropertyValue<CHandle<animISyncMethod>>();
			set => SetPropertyValue<CHandle<animISyncMethod>>(value);
		}

		[Ordinal(14)] 
		[RED("inputNodes")] 
		public CArray<animPoseLink> InputNodes
		{
			get => GetPropertyValue<CArray<animPoseLink>>();
			set => SetPropertyValue<CArray<animPoseLink>>(value);
		}

		[Ordinal(15)] 
		[RED("canRequestInertialization")] 
		public CBool CanRequestInertialization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_BaseSwitch()
		{
			Id = uint.MaxValue;
			InputNodes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
