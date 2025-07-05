using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewHitDataEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hitIntensity")] 
		public CInt32 HitIntensity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("hitSource")] 
		public CInt32 HitSource
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("hitType")] 
		public CInt32 HitType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("hitBodyPart")] 
		public CInt32 HitBodyPart
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("hitNpcMovementSpeed")] 
		public CInt32 HitNpcMovementSpeed
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("hitDirection")] 
		public CInt32 HitDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("hitNpcMovementDirection")] 
		public CInt32 HitNpcMovementDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("stance")] 
		public CInt32 Stance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public NewHitDataEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
