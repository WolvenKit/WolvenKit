using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimAnimationLibraryResource : CResource
	{
		[Ordinal(1)] 
		[RED("sequences")] 
		public CArray<CHandle<inkanimSequence>> Sequences
		{
			get => GetPropertyValue<CArray<CHandle<inkanimSequence>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimSequence>>>(value);
		}

		public inkanimAnimationLibraryResource()
		{
			Sequences = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
