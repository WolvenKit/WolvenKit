using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFallbackFrameDesc : CVariable
	{
		private CUInt16 _mPositions;
		private CUInt16 _mRotations;

		[Ordinal(0)] 
		[RED("mPositions")] 
		public CUInt16 MPositions
		{
			get => GetProperty(ref _mPositions);
			set => SetProperty(ref _mPositions, value);
		}

		[Ordinal(1)] 
		[RED("mRotations")] 
		public CUInt16 MRotations
		{
			get => GetProperty(ref _mRotations);
			set => SetProperty(ref _mRotations, value);
		}

		public animAnimFallbackFrameDesc(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
