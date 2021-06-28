using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PickerChoosenQuantityChangedEvent : inkGameNotificationData
	{
		private CInt32 _choosenQuantity;

		[Ordinal(6)] 
		[RED("choosenQuantity")] 
		public CInt32 ChoosenQuantity
		{
			get => GetProperty(ref _choosenQuantity);
			set => SetProperty(ref _choosenQuantity, value);
		}

		public PickerChoosenQuantityChangedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
