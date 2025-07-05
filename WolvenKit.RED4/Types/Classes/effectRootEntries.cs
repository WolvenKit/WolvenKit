using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectRootEntries : effectIPlacementEntries
	{
		[Ordinal(0)] 
		[RED("inheritRotation")] 
		public CBool InheritRotation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("roots")] 
		public CArray<effectRootEntry> Roots
		{
			get => GetPropertyValue<CArray<effectRootEntry>>();
			set => SetPropertyValue<CArray<effectRootEntry>>(value);
		}

		public effectRootEntries()
		{
			InheritRotation = true;
			Roots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
