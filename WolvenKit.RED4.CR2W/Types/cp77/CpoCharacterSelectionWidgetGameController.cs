using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CpoCharacterSelectionWidgetGameController : gameuiWidgetGameController
	{
		private CString _defaultCharacterTexturePart;
		private CString _soloCharacterTexturePart;
		private CArray<wCHandle<inkHorizontalPanelWidget>> _horizontalPanelsList;
		private CInt32 _amount;

		[Ordinal(2)] 
		[RED("defaultCharacterTexturePart")] 
		public CString DefaultCharacterTexturePart
		{
			get => GetProperty(ref _defaultCharacterTexturePart);
			set => SetProperty(ref _defaultCharacterTexturePart, value);
		}

		[Ordinal(3)] 
		[RED("soloCharacterTexturePart")] 
		public CString SoloCharacterTexturePart
		{
			get => GetProperty(ref _soloCharacterTexturePart);
			set => SetProperty(ref _soloCharacterTexturePart, value);
		}

		[Ordinal(4)] 
		[RED("horizontalPanelsList")] 
		public CArray<wCHandle<inkHorizontalPanelWidget>> HorizontalPanelsList
		{
			get => GetProperty(ref _horizontalPanelsList);
			set => SetProperty(ref _horizontalPanelsList, value);
		}

		[Ordinal(5)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		public CpoCharacterSelectionWidgetGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
