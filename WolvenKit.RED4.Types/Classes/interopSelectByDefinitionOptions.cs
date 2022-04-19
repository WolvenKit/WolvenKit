using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopSelectByDefinitionOptions : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("searchInSelection")] 
		public CBool SearchInSelection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("minBBoxDiagonalLength")] 
		public CFloat MinBBoxDiagonalLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("maxBBoxDiagonalLength")] 
		public CFloat MaxBBoxDiagonalLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("maxBBoxParentPercantageDiagonalLength")] 
		public CFloat MaxBBoxParentPercantageDiagonalLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("includePrefabNodes")] 
		public CBool IncludePrefabNodes
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("includeDecalNodes")] 
		public CBool IncludeDecalNodes
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("includeMeshNodes")] 
		public CBool IncludeMeshNodes
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public interopSelectByDefinitionOptions()
		{
			MaxBBoxDiagonalLength = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
