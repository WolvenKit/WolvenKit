using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SCustomDeviceActionsData : RedBaseClass
	{
		private CArray<SDeviceActionCustomData> _actions;

		[Ordinal(0)] 
		[RED("actions")] 
		public CArray<SDeviceActionCustomData> Actions
		{
			get => GetProperty(ref _actions);
			set => SetProperty(ref _actions, value);
		}
	}
}
