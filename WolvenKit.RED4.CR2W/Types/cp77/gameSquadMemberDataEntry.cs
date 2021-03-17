using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSquadMemberDataEntry : CVariable
	{
		private CName _squadName;
		private CEnum<AISquadType> _squadType;

		[Ordinal(0)] 
		[RED("squadName")] 
		public CName SquadName
		{
			get => GetProperty(ref _squadName);
			set => SetProperty(ref _squadName, value);
		}

		[Ordinal(1)] 
		[RED("squadType")] 
		public CEnum<AISquadType> SquadType
		{
			get => GetProperty(ref _squadType);
			set => SetProperty(ref _squadType, value);
		}

		public gameSquadMemberDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
