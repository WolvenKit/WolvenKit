using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QueueCombatExperience : gamePlayerScriptableSystemRequest
	{
		private CFloat _amount;
		private CEnum<gamedataProficiencyType> _experienceType;
		private entEntityID _entity;

		[Ordinal(1)] 
		[RED("amount")] 
		public CFloat Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		[Ordinal(2)] 
		[RED("experienceType")] 
		public CEnum<gamedataProficiencyType> ExperienceType
		{
			get => GetProperty(ref _experienceType);
			set => SetProperty(ref _experienceType, value);
		}

		[Ordinal(3)] 
		[RED("entity")] 
		public entEntityID Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		public QueueCombatExperience(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
