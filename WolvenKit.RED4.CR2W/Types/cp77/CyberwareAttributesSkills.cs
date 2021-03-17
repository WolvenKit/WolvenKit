using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareAttributesSkills : gameuiWidgetGameController
	{
		private CyberwareAttributes_ContainersStruct _attributes;
		private CyberwareAttributes_ResistancesStruct _resistances;
		private inkTextWidgetReference _levelUpPoints;
		private CHandle<gameIBlackboard> _uiBlackboard;
		private wCHandle<PlayerPuppet> _playerPuppet;
		private CInt32 _devPoints;

		[Ordinal(2)] 
		[RED("attributes")] 
		public CyberwareAttributes_ContainersStruct Attributes
		{
			get => GetProperty(ref _attributes);
			set => SetProperty(ref _attributes, value);
		}

		[Ordinal(3)] 
		[RED("resistances")] 
		public CyberwareAttributes_ResistancesStruct Resistances
		{
			get => GetProperty(ref _resistances);
			set => SetProperty(ref _resistances, value);
		}

		[Ordinal(4)] 
		[RED("levelUpPoints")] 
		public inkTextWidgetReference LevelUpPoints
		{
			get => GetProperty(ref _levelUpPoints);
			set => SetProperty(ref _levelUpPoints, value);
		}

		[Ordinal(5)] 
		[RED("uiBlackboard")] 
		public CHandle<gameIBlackboard> UiBlackboard
		{
			get => GetProperty(ref _uiBlackboard);
			set => SetProperty(ref _uiBlackboard, value);
		}

		[Ordinal(6)] 
		[RED("playerPuppet")] 
		public wCHandle<PlayerPuppet> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(7)] 
		[RED("devPoints")] 
		public CInt32 DevPoints
		{
			get => GetProperty(ref _devPoints);
			set => SetProperty(ref _devPoints, value);
		}

		public CyberwareAttributesSkills(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
