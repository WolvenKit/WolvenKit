using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseCorrectionParams : CVariable
	{
		private animPoseCorrectionGroup _poseCorrectionGroup;
		private CFloat _blendDuration;

		[Ordinal(0)] 
		[RED("poseCorrectionGroup")] 
		public animPoseCorrectionGroup PoseCorrectionGroup
		{
			get => GetProperty(ref _poseCorrectionGroup);
			set => SetProperty(ref _poseCorrectionGroup, value);
		}

		[Ordinal(1)] 
		[RED("blendDuration")] 
		public CFloat BlendDuration
		{
			get => GetProperty(ref _blendDuration);
			set => SetProperty(ref _blendDuration, value);
		}

		public animPoseCorrectionParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
