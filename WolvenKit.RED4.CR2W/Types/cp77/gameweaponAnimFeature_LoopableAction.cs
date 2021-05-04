using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponAnimFeature_LoopableAction : animAnimFeature
	{
		private CFloat _loopDuration;
		private CUInt8 _numLoops;
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("loopDuration")] 
		public CFloat LoopDuration
		{
			get => GetProperty(ref _loopDuration);
			set => SetProperty(ref _loopDuration, value);
		}

		[Ordinal(1)] 
		[RED("numLoops")] 
		public CUInt8 NumLoops
		{
			get => GetProperty(ref _numLoops);
			set => SetProperty(ref _numLoops, value);
		}

		[Ordinal(2)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		public gameweaponAnimFeature_LoopableAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
