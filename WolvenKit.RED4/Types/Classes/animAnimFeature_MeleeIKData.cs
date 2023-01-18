using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_MeleeIKData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("headPosition")] 
		public Vector4 HeadPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("chestPosition")] 
		public Vector4 ChestPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("ikOffset")] 
		public Vector4 IkOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public animAnimFeature_MeleeIKData()
		{
			HeadPosition = new();
			ChestPosition = new();
			IkOffset = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
