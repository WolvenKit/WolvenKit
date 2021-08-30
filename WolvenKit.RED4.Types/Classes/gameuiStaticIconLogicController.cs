using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiStaticIconLogicController : gameuiDynamicIconLogicController
	{
		private TweakDBID _iconReference;

		[Ordinal(1)] 
		[RED("iconReference")] 
		public TweakDBID IconReference
		{
			get => GetProperty(ref _iconReference);
			set => SetProperty(ref _iconReference, value);
		}

		public gameuiStaticIconLogicController()
		{
			_iconReference = new() { Value = 61952742650 };
		}
	}
}
