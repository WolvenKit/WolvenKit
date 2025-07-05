using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BlendByMaskDynamic : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("base")] 
		public animPoseLink Base
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(12)] 
		[RED("blend")] 
		public animPoseLink Blend
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(13)] 
		[RED("mask")] 
		public animIntLink Mask
		{
			get => GetPropertyValue<animIntLink>();
			set => SetPropertyValue<animIntLink>(value);
		}

		[Ordinal(14)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(15)] 
		[RED("masks")] 
		public CArray<CName> Masks
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(16)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetPropertyValue<CHandle<animISyncMethod>>();
			set => SetPropertyValue<CHandle<animISyncMethod>>(value);
		}

		public animAnimNode_BlendByMaskDynamic()
		{
			Id = uint.MaxValue;
			Base = new animPoseLink();
			Blend = new animPoseLink();
			Mask = new animIntLink();
			Weight = new animFloatLink();
			Masks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
