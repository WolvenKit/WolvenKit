using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerLevel : ScannerChunk
	{
		private CInt32 _level;
		private CBool _isHard;

		[Ordinal(0)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(1)] 
		[RED("isHard")] 
		public CBool IsHard
		{
			get => GetProperty(ref _isHard);
			set => SetProperty(ref _isHard, value);
		}

		public ScannerLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
