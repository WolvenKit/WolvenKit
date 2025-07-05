using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class megatronFullAutoController : AmmoLogicController
	{
		[Ordinal(3)] 
		[RED("ammoCountText")] 
		public CWeakHandle<inkTextWidget> AmmoCountText
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("ammoBar")] 
		public CWeakHandle<inkImageWidget> AmmoBar
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		public megatronFullAutoController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
