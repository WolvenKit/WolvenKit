using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class locVoiceTag : CVariable
	{
		private CName _voiceTag;
		private CString _voicesetScenePath;
		private CRUID _id;
		private CBool _isApuc;

		[Ordinal(0)] 
		[RED("voiceTag")] 
		public CName VoiceTag
		{
			get => GetProperty(ref _voiceTag);
			set => SetProperty(ref _voiceTag, value);
		}

		[Ordinal(1)] 
		[RED("voicesetScenePath")] 
		public CString VoicesetScenePath
		{
			get => GetProperty(ref _voicesetScenePath);
			set => SetProperty(ref _voicesetScenePath, value);
		}

		[Ordinal(2)] 
		[RED("id")] 
		public CRUID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(3)] 
		[RED("isApuc")] 
		public CBool IsApuc
		{
			get => GetProperty(ref _isApuc);
			set => SetProperty(ref _isApuc, value);
		}

		public locVoiceTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
