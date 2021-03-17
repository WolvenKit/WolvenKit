using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_FootIK : animAnimEvent
	{
		private CEnum<animLeg> _leg;

		[Ordinal(3)] 
		[RED("leg")] 
		public CEnum<animLeg> Leg
		{
			get => GetProperty(ref _leg);
			set => SetProperty(ref _leg, value);
		}

		public animAnimEvent_FootIK(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
