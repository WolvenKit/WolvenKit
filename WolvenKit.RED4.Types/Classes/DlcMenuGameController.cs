using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DlcMenuGameController : gameuiMenuGameController
	{
		private inkWidgetReference _buttonHintsRef;
		private inkCompoundWidgetReference _containersRef;

		[Ordinal(3)] 
		[RED("buttonHintsRef")] 
		public inkWidgetReference ButtonHintsRef
		{
			get => GetProperty(ref _buttonHintsRef);
			set => SetProperty(ref _buttonHintsRef, value);
		}

		[Ordinal(4)] 
		[RED("containersRef")] 
		public inkCompoundWidgetReference ContainersRef
		{
			get => GetProperty(ref _containersRef);
			set => SetProperty(ref _containersRef, value);
		}
	}
}
