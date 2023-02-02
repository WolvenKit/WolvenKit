using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameLastHitData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetEntityId")] 
		public entEntityID TargetEntityId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("hitType")] 
		public CUInt32 HitType
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("hitShapes")] 
		public CArray<CName> HitShapes
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameLastHitData()
		{
			TargetEntityId = new();
			HitShapes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
