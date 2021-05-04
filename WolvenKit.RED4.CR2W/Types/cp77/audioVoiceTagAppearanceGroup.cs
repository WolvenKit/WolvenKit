using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTagAppearanceGroup : CVariable
	{
		private CArray<CName> _appearances;
		private CArray<CName> _voicetags;

		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetProperty(ref _appearances);
			set => SetProperty(ref _appearances, value);
		}

		[Ordinal(1)] 
		[RED("voicetags")] 
		public CArray<CName> Voicetags
		{
			get => GetProperty(ref _voicetags);
			set => SetProperty(ref _voicetags, value);
		}

		public audioVoiceTagAppearanceGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
