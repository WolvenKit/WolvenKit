using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectBoneEntries : effectIPlacementEntries
	{
		private CBool _inheritRotation;
		private CArray<effectBoneEntry> _bones;

		[Ordinal(0)] 
		[RED("inheritRotation")] 
		public CBool InheritRotation
		{
			get => GetProperty(ref _inheritRotation);
			set => SetProperty(ref _inheritRotation, value);
		}

		[Ordinal(1)] 
		[RED("bones")] 
		public CArray<effectBoneEntry> Bones
		{
			get => GetProperty(ref _bones);
			set => SetProperty(ref _bones, value);
		}
	}
}
