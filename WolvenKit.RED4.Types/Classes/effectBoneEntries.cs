using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectBoneEntries : effectIPlacementEntries
	{
		[Ordinal(0)] 
		[RED("inheritRotation")] 
		public CBool InheritRotation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("bones")] 
		public CArray<effectBoneEntry> Bones
		{
			get => GetPropertyValue<CArray<effectBoneEntry>>();
			set => SetPropertyValue<CArray<effectBoneEntry>>(value);
		}

		public effectBoneEntries()
		{
			InheritRotation = true;
			Bones = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
