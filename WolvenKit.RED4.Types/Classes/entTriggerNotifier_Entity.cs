using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entTriggerNotifier_Entity : worldITriggerAreaNotifer
	{
		private NodeRef _entityRef;

		[Ordinal(3)] 
		[RED("entityRef")] 
		public NodeRef EntityRef
		{
			get => GetProperty(ref _entityRef);
			set => SetProperty(ref _entityRef, value);
		}
	}
}
