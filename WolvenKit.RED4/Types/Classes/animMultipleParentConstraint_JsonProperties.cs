using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animMultipleParentConstraint_JsonProperties : ISerializable
	{
		[Ordinal(0)] 
		[RED("parentsTransforms")] 
		public CArray<animMultipleParentConstraint_JsonEntry> ParentsTransforms
		{
			get => GetPropertyValue<CArray<animMultipleParentConstraint_JsonEntry>>();
			set => SetPropertyValue<CArray<animMultipleParentConstraint_JsonEntry>>(value);
		}

		[Ordinal(1)] 
		[RED("transformIndex")] 
		public CName TransformIndex
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("weightMode")] 
		public CEnum<animConstraintWeightMode> WeightMode
		{
			get => GetPropertyValue<CEnum<animConstraintWeightMode>>();
			set => SetPropertyValue<CEnum<animConstraintWeightMode>>(value);
		}

		[Ordinal(3)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("weightFloatTrack")] 
		public CName WeightFloatTrack
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animMultipleParentConstraint_JsonProperties()
		{
			ParentsTransforms = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
