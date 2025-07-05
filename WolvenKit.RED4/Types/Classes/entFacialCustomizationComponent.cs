using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entFacialCustomizationComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("debugIgnoreComponent")] 
		public CBool DebugIgnoreComponent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("customizationSet")] 
		public CResourceAsyncReference<animFacialCustomizationSet> CustomizationSet
		{
			get => GetPropertyValue<CResourceAsyncReference<animFacialCustomizationSet>>();
			set => SetPropertyValue<CResourceAsyncReference<animFacialCustomizationSet>>(value);
		}

		[Ordinal(5)] 
		[RED("eyes")] 
		public CUInt32 Eyes
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("nose")] 
		public CUInt32 Nose
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("mouth")] 
		public CUInt32 Mouth
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("jaw")] 
		public CUInt32 Jaw
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("ears")] 
		public CUInt32 Ears
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public entFacialCustomizationComponent()
		{
			Name = "Component";
			DebugIgnoreComponent = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
