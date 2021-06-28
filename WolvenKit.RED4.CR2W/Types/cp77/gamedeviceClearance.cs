using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceClearance : IScriptable
	{
		private CInt32 _min;
		private CInt32 _max;

		[Ordinal(0)] 
		[RED("min")] 
		public CInt32 Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(1)] 
		[RED("max")] 
		public CInt32 Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}

		public gamedeviceClearance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
