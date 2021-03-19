using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterGroupAttitude_CondtionType : questICharacterConditionType
	{
		private CName _group1Name;
		private CName _group2Name;
		private CEnum<EAIAttitude> _attitude;

		[Ordinal(0)] 
		[RED("group1Name")] 
		public CName Group1Name
		{
			get => GetProperty(ref _group1Name);
			set => SetProperty(ref _group1Name, value);
		}

		[Ordinal(1)] 
		[RED("group2Name")] 
		public CName Group2Name
		{
			get => GetProperty(ref _group2Name);
			set => SetProperty(ref _group2Name, value);
		}

		[Ordinal(2)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetProperty(ref _attitude);
			set => SetProperty(ref _attitude, value);
		}

		public questCharacterGroupAttitude_CondtionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
