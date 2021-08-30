using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopSelectByDefinitionOptions : RedBaseClass
	{
		private CBool _searchInSelection;
		private CFloat _minBBoxDiagonalLength;
		private CFloat _maxBBoxDiagonalLength;
		private CFloat _maxBBoxParentPercantageDiagonalLength;
		private CBool _includePrefabNodes;
		private CBool _includeDecalNodes;
		private CBool _includeMeshNodes;

		[Ordinal(0)] 
		[RED("searchInSelection")] 
		public CBool SearchInSelection
		{
			get => GetProperty(ref _searchInSelection);
			set => SetProperty(ref _searchInSelection, value);
		}

		[Ordinal(1)] 
		[RED("minBBoxDiagonalLength")] 
		public CFloat MinBBoxDiagonalLength
		{
			get => GetProperty(ref _minBBoxDiagonalLength);
			set => SetProperty(ref _minBBoxDiagonalLength, value);
		}

		[Ordinal(2)] 
		[RED("maxBBoxDiagonalLength")] 
		public CFloat MaxBBoxDiagonalLength
		{
			get => GetProperty(ref _maxBBoxDiagonalLength);
			set => SetProperty(ref _maxBBoxDiagonalLength, value);
		}

		[Ordinal(3)] 
		[RED("maxBBoxParentPercantageDiagonalLength")] 
		public CFloat MaxBBoxParentPercantageDiagonalLength
		{
			get => GetProperty(ref _maxBBoxParentPercantageDiagonalLength);
			set => SetProperty(ref _maxBBoxParentPercantageDiagonalLength, value);
		}

		[Ordinal(4)] 
		[RED("includePrefabNodes")] 
		public CBool IncludePrefabNodes
		{
			get => GetProperty(ref _includePrefabNodes);
			set => SetProperty(ref _includePrefabNodes, value);
		}

		[Ordinal(5)] 
		[RED("includeDecalNodes")] 
		public CBool IncludeDecalNodes
		{
			get => GetProperty(ref _includeDecalNodes);
			set => SetProperty(ref _includeDecalNodes, value);
		}

		[Ordinal(6)] 
		[RED("includeMeshNodes")] 
		public CBool IncludeMeshNodes
		{
			get => GetProperty(ref _includeMeshNodes);
			set => SetProperty(ref _includeMeshNodes, value);
		}

		public interopSelectByDefinitionOptions()
		{
			_maxBBoxDiagonalLength = 5.000000F;
		}
	}
}
