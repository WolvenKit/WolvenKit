using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectRootEntries : effectIPlacementEntries
	{
		private CBool _inheritRotation;
		private CArray<effectRootEntry> _roots;

		[Ordinal(0)] 
		[RED("inheritRotation")] 
		public CBool InheritRotation
		{
			get => GetProperty(ref _inheritRotation);
			set => SetProperty(ref _inheritRotation, value);
		}

		[Ordinal(1)] 
		[RED("roots")] 
		public CArray<effectRootEntry> Roots
		{
			get => GetProperty(ref _roots);
			set => SetProperty(ref _roots, value);
		}
	}
}
