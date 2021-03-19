using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsStopDialogLine : redEvent
	{
		private CRUID _stringId;
		private CFloat _fadeOut;

		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetProperty(ref _stringId);
			set => SetProperty(ref _stringId, value);
		}

		[Ordinal(1)] 
		[RED("fadeOut")] 
		public CFloat FadeOut
		{
			get => GetProperty(ref _fadeOut);
			set => SetProperty(ref _fadeOut, value);
		}

		public gameaudioeventsStopDialogLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
