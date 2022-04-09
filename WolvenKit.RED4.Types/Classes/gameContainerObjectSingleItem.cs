using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameContainerObjectSingleItem : gameContainerObjectBase
	{
		[Ordinal(46)] 
		[RED("itemTDBID")] 
		public TweakDBID ItemTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameContainerObjectSingleItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
