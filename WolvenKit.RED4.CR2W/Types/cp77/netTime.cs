using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netTime : CVariable
	{
		private CUInt64 _milliSecs;

		[Ordinal(0)] 
		[RED("milliSecs")] 
		public CUInt64 MilliSecs
		{
			get => GetProperty(ref _milliSecs);
			set => SetProperty(ref _milliSecs, value);
		}

		public netTime(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
