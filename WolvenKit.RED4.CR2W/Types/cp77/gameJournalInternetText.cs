using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetText : gameJournalInternetBase
	{
		private LocalizationString _text;

		[Ordinal(4)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		public gameJournalInternetText(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
