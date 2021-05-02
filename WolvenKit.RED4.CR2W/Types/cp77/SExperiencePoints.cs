using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SExperiencePoints : CVariable
	{
		private CFloat _amount;
		private CEnum<gamedataProficiencyType> _forType;
		private entEntityID _entity;

		[Ordinal(0)] 
		[RED("amount")] 
		public CFloat Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		[Ordinal(1)] 
		[RED("forType")] 
		public CEnum<gamedataProficiencyType> ForType
		{
			get => GetProperty(ref _forType);
			set => SetProperty(ref _forType, value);
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public entEntityID Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		public SExperiencePoints(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
