using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityLockerControllerPS : ScriptableDeviceComponentPS
	{
		private SecurityLockerProperties _securityLockerProperties;
		private CBool _isStoringPlayerEquipement;

		[Ordinal(103)] 
		[RED("securityLockerProperties")] 
		public SecurityLockerProperties SecurityLockerProperties
		{
			get => GetProperty(ref _securityLockerProperties);
			set => SetProperty(ref _securityLockerProperties, value);
		}

		[Ordinal(104)] 
		[RED("isStoringPlayerEquipement")] 
		public CBool IsStoringPlayerEquipement
		{
			get => GetProperty(ref _isStoringPlayerEquipement);
			set => SetProperty(ref _isStoringPlayerEquipement, value);
		}

		public SecurityLockerControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
