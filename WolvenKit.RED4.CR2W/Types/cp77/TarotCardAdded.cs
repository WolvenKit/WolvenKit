using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TarotCardAdded : redEvent
	{
		private CName _imagePart;
		private CString _cardName;

		[Ordinal(0)] 
		[RED("imagePart")] 
		public CName ImagePart
		{
			get => GetProperty(ref _imagePart);
			set => SetProperty(ref _imagePart, value);
		}

		[Ordinal(1)] 
		[RED("cardName")] 
		public CString CardName
		{
			get => GetProperty(ref _cardName);
			set => SetProperty(ref _cardName, value);
		}

		public TarotCardAdded(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
