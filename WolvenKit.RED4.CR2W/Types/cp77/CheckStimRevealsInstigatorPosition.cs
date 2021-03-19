using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckStimRevealsInstigatorPosition : AIbehaviorconditionScript
	{
		private CBool _checkStimType;
		private CEnum<gamedataStimType> _stimType;

		[Ordinal(0)] 
		[RED("checkStimType")] 
		public CBool CheckStimType
		{
			get => GetProperty(ref _checkStimType);
			set => SetProperty(ref _checkStimType, value);
		}

		[Ordinal(1)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetProperty(ref _stimType);
			set => SetProperty(ref _stimType, value);
		}

		public CheckStimRevealsInstigatorPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
