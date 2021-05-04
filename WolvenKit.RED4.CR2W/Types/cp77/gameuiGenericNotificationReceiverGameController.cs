using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGenericNotificationReceiverGameController : gameuiWidgetGameController
	{
		private inkEmptyCallback _itemChanged;

		[Ordinal(2)] 
		[RED("ItemChanged")] 
		public inkEmptyCallback ItemChanged
		{
			get => GetProperty(ref _itemChanged);
			set => SetProperty(ref _itemChanged, value);
		}

		public gameuiGenericNotificationReceiverGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
