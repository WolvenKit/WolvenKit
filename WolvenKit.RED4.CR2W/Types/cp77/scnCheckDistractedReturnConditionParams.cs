using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckDistractedReturnConditionParams : CVariable
	{
		private CBool _distracted;
		private CEnum<scnDistractedConditionTarget> _target;

		[Ordinal(0)] 
		[RED("distracted")] 
		public CBool Distracted
		{
			get => GetProperty(ref _distracted);
			set => SetProperty(ref _distracted, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public CEnum<scnDistractedConditionTarget> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		public scnCheckDistractedReturnConditionParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
