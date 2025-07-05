using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_MultiBoolToFloatValue : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("allMustBeTrue")] 
		public CBool AllMustBeTrue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("onTrue")] 
		public CFloat OnTrue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("onFalse")] 
		public CFloat OnFalse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("inputsData")] 
		public CArray<animAnimMultiBoolToFloatEntry> InputsData
		{
			get => GetPropertyValue<CArray<animAnimMultiBoolToFloatEntry>>();
			set => SetPropertyValue<CArray<animAnimMultiBoolToFloatEntry>>(value);
		}

		public animAnimNode_MultiBoolToFloatValue()
		{
			Id = uint.MaxValue;
			OnTrue = 1.000000F;
			InputsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
