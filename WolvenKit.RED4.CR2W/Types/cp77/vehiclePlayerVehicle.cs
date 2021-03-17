using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehiclePlayerVehicle : CVariable
	{
		private CName _name;
		private TweakDBID _recordID;
		private CEnum<gamedataVehicleType> _vehicleType;
		private CBool _isUnlocked;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(2)] 
		[RED("vehicleType")] 
		public CEnum<gamedataVehicleType> VehicleType
		{
			get => GetProperty(ref _vehicleType);
			set => SetProperty(ref _vehicleType, value);
		}

		[Ordinal(3)] 
		[RED("isUnlocked")] 
		public CBool IsUnlocked
		{
			get => GetProperty(ref _isUnlocked);
			set => SetProperty(ref _isUnlocked, value);
		}

		public vehiclePlayerVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
