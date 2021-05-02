using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceAnimSetup : CVariable
	{
		private CFloat _animationTime;

		[Ordinal(0)] 
		[RED("animationTime")] 
		public CFloat AnimationTime
		{
			get => GetProperty(ref _animationTime);
			set => SetProperty(ref _animationTime, value);
		}

		public ActivatedDeviceAnimSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
