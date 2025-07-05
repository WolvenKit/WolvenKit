using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameRazerChromaAnimationDatabase : CResource
	{
		[Ordinal(1)] 
		[RED("setsSerialized")] 
		public CArray<gameRazerChromaAnimationSet> SetsSerialized
		{
			get => GetPropertyValue<CArray<gameRazerChromaAnimationSet>>();
			set => SetPropertyValue<CArray<gameRazerChromaAnimationSet>>(value);
		}

		public gameRazerChromaAnimationDatabase()
		{
			SetsSerialized = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
