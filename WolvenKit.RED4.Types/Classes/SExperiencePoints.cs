using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SExperiencePoints : RedBaseClass
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
	}
}
