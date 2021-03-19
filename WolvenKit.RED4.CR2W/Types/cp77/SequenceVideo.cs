using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SequenceVideo : CVariable
	{
		private redResourceReferenceScriptToken _videoPath;
		private CName _audioEvent;
		private CBool _looped;

		[Ordinal(0)] 
		[RED("videoPath")] 
		public redResourceReferenceScriptToken VideoPath
		{
			get => GetProperty(ref _videoPath);
			set => SetProperty(ref _videoPath, value);
		}

		[Ordinal(1)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetProperty(ref _audioEvent);
			set => SetProperty(ref _audioEvent, value);
		}

		[Ordinal(2)] 
		[RED("looped")] 
		public CBool Looped
		{
			get => GetProperty(ref _looped);
			set => SetProperty(ref _looped, value);
		}

		public SequenceVideo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
