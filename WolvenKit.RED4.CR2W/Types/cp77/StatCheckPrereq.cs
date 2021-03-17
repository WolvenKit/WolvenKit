using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatCheckPrereq : DevelopmentCheckPrereq
	{
		private CEnum<gamedataStatType> _statToCheck;

		[Ordinal(1)] 
		[RED("statToCheck")] 
		public CEnum<gamedataStatType> StatToCheck
		{
			get => GetProperty(ref _statToCheck);
			set => SetProperty(ref _statToCheck, value);
		}

		public StatCheckPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
