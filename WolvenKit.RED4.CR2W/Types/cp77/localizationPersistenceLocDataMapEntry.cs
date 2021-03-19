using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceLocDataMapEntry : CVariable
	{
		private CName _langCode;
		private raRef<JsonResource> _onscreensPath;
		private raRef<JsonResource> _subtitlePath;

		[Ordinal(0)] 
		[RED("langCode")] 
		public CName LangCode
		{
			get => GetProperty(ref _langCode);
			set => SetProperty(ref _langCode, value);
		}

		[Ordinal(1)] 
		[RED("onscreensPath")] 
		public raRef<JsonResource> OnscreensPath
		{
			get => GetProperty(ref _onscreensPath);
			set => SetProperty(ref _onscreensPath, value);
		}

		[Ordinal(2)] 
		[RED("subtitlePath")] 
		public raRef<JsonResource> SubtitlePath
		{
			get => GetProperty(ref _subtitlePath);
			set => SetProperty(ref _subtitlePath, value);
		}

		public localizationPersistenceLocDataMapEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
