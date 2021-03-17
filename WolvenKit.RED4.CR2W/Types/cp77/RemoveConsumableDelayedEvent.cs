using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveConsumableDelayedEvent : redEvent
	{
		private CHandle<ConsumeAction> _consumeAction;

		[Ordinal(0)] 
		[RED("consumeAction")] 
		public CHandle<ConsumeAction> ConsumeAction
		{
			get => GetProperty(ref _consumeAction);
			set => SetProperty(ref _consumeAction, value);
		}

		public RemoveConsumableDelayedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
