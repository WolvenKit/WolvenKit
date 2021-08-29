using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questLevelUpData : RedBaseClass
	{
		private CInt32 _lvl;
		private CEnum<gamedataProficiencyType> _type;
		private CInt32 _perkPoints;
		private CInt32 _attributePoints;
		private CBool _disableAction;

		[Ordinal(0)] 
		[RED("lvl")] 
		public CInt32 Lvl
		{
			get => GetProperty(ref _lvl);
			set => SetProperty(ref _lvl, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("perkPoints")] 
		public CInt32 PerkPoints
		{
			get => GetProperty(ref _perkPoints);
			set => SetProperty(ref _perkPoints, value);
		}

		[Ordinal(3)] 
		[RED("attributePoints")] 
		public CInt32 AttributePoints
		{
			get => GetProperty(ref _attributePoints);
			set => SetProperty(ref _attributePoints, value);
		}

		[Ordinal(4)] 
		[RED("disableAction")] 
		public CBool DisableAction
		{
			get => GetProperty(ref _disableAction);
			set => SetProperty(ref _disableAction, value);
		}
	}
}
