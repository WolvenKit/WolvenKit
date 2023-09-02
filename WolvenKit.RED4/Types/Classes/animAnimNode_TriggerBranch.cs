using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_TriggerBranch : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("base")] 
		public animPoseLink Base
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(12)] 
		[RED("overlay")] 
		public animPoseLink Overlay
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(13)] 
		[RED("blendIn")] 
		public CFloat BlendIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("blendOut")] 
		public CFloat BlendOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("startEvent")] 
		public CName StartEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("endEvent")] 
		public CName EndEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimNode_TriggerBranch()
		{
			Id = uint.MaxValue;
			Base = new animPoseLink();
			Overlay = new animPoseLink();
			Cooldown = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
