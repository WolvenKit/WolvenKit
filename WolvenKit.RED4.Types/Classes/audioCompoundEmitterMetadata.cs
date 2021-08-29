using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioCompoundEmitterMetadata : audioEmitterMetadata
	{
		private CArray<CName> _childrenNames;

		[Ordinal(1)] 
		[RED("childrenNames")] 
		public CArray<CName> ChildrenNames
		{
			get => GetProperty(ref _childrenNames);
			set => SetProperty(ref _childrenNames, value);
		}
	}
}
