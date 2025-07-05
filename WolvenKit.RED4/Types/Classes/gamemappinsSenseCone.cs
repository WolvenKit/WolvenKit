using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsSenseCone : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("length")] 
		public CFloat Length
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("angleDegrees")] 
		public CFloat AngleDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("position1")] 
		public Vector4 Position1
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("position2")] 
		public Vector4 Position2
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gamemappinsSenseCone()
		{
			Position1 = new Vector4();
			Position2 = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
