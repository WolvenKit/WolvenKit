using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTarotCardAddedNotificationViewData : gameuiGenericNotificationViewData
	{
		private CName _imagePart;
		private CString _cardName;
		private CName _animation;

		[Ordinal(5)] 
		[RED("imagePart")] 
		public CName ImagePart
		{
			get => GetProperty(ref _imagePart);
			set => SetProperty(ref _imagePart, value);
		}

		[Ordinal(6)] 
		[RED("cardName")] 
		public CString CardName
		{
			get => GetProperty(ref _cardName);
			set => SetProperty(ref _cardName, value);
		}

		[Ordinal(7)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		public gameuiTarotCardAddedNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
