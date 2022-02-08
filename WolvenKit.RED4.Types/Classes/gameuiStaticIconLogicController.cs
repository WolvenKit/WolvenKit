using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiStaticIconLogicController : gameuiDynamicIconLogicController
	{
		[Ordinal(1)] 
		[RED("iconReference")] 
		public TweakDBID IconReference
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameuiStaticIconLogicController()
		{
			IconReference = new() { Value = 61952742650 };
		}
	}
}
