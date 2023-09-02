using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animGenericAnimDatabase_DatabaseRow : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("inputValues")] 
		public CArray<CInt32> InputValues
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(1)] 
		[RED("animationData")] 
		public animGenericAnimDatabase_AnimationData AnimationData
		{
			get => GetPropertyValue<animGenericAnimDatabase_AnimationData>();
			set => SetPropertyValue<animGenericAnimDatabase_AnimationData>(value);
		}

		public animGenericAnimDatabase_DatabaseRow()
		{
			InputValues = new();
			AnimationData = new animGenericAnimDatabase_AnimationData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
