using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BinkVideoEvent : redEvent
	{
		private redResourceReferenceScriptToken _path;
		private CFloat _startingTime;
		private CBool _shouldPlay;

		[Ordinal(0)] 
		[RED("path")] 
		public redResourceReferenceScriptToken Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(1)] 
		[RED("startingTime")] 
		public CFloat StartingTime
		{
			get => GetProperty(ref _startingTime);
			set => SetProperty(ref _startingTime, value);
		}

		[Ordinal(2)] 
		[RED("shouldPlay")] 
		public CBool ShouldPlay
		{
			get => GetProperty(ref _shouldPlay);
			set => SetProperty(ref _shouldPlay, value);
		}

		public BinkVideoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
