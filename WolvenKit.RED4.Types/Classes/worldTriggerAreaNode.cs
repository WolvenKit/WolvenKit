using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTriggerAreaNode : worldAreaShapeNode
	{
		private CArray<CHandle<worldITriggerAreaNotifer>> _notifiers;

		[Ordinal(6)] 
		[RED("notifiers")] 
		public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers
		{
			get => GetProperty(ref _notifiers);
			set => SetProperty(ref _notifiers, value);
		}
	}
}
