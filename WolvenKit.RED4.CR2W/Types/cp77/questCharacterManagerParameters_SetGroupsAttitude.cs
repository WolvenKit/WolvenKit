using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetGroupsAttitude : questICharacterManagerParameters_NodeSubType
	{
		private CBool _set;
		private CName _group1Name;
		private CName _group2Name;
		private CEnum<EAIAttitude> _attitude;

		[Ordinal(0)] 
		[RED("set")] 
		public CBool Set
		{
			get => GetProperty(ref _set);
			set => SetProperty(ref _set, value);
		}

		[Ordinal(1)] 
		[RED("group1Name")] 
		public CName Group1Name
		{
			get => GetProperty(ref _group1Name);
			set => SetProperty(ref _group1Name, value);
		}

		[Ordinal(2)] 
		[RED("group2Name")] 
		public CName Group2Name
		{
			get => GetProperty(ref _group2Name);
			set => SetProperty(ref _group2Name, value);
		}

		[Ordinal(3)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetProperty(ref _attitude);
			set => SetProperty(ref _attitude, value);
		}

		public questCharacterManagerParameters_SetGroupsAttitude(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
