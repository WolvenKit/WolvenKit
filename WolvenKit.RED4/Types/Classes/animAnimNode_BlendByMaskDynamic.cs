using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BlendByMaskDynamic : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("base")] 
		public animPoseLink Base
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(2)] 
		[RED("blend")] 
		public animPoseLink Blend
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(3)] 
		[RED("mask")] 
		public animIntLink Mask
		{
			get => GetPropertyValue<animIntLink>();
			set => SetPropertyValue<animIntLink>(value);
		}

		[Ordinal(4)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(5)] 
		[RED("masks")] 
		public CArray<CName> Masks
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
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
