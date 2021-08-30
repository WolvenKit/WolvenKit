using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class C4ControllerPS : ExplosiveDeviceControllerPS
	{
		private CName _itemTweakDBString;

		[Ordinal(120)] 
		[RED("itemTweakDBString")] 
		public CName ItemTweakDBString
		{
			get => GetProperty(ref _itemTweakDBString);
			set => SetProperty(ref _itemTweakDBString, value);
		}

		public C4ControllerPS()
		{
			_itemTweakDBString = "C4";
		}
	}
}
