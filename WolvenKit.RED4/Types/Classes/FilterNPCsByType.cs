using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FilterNPCsByType : gameEffectObjectSingleFilter_Scripted
	{
		[Ordinal(0)] 
		[RED("allowedTypes")] 
		public CArray<CEnum<gamedataNPCType>> AllowedTypes
		{
			get => GetPropertyValue<CArray<CEnum<gamedataNPCType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataNPCType>>>(value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FilterNPCsByType()
		{
			AllowedTypes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
