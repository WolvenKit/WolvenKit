using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEnablePlayerVehicle_NodeType : questIVehicleManagerNodeType
	{
		private CString _vehicle;
		private CBool _enable;
		private CBool _despawn;
		private CBool _makePlayerActiveVehicle;

		[Ordinal(0)] 
		[RED("vehicle")] 
		public CString Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(2)] 
		[RED("despawn")] 
		public CBool Despawn
		{
			get => GetProperty(ref _despawn);
			set => SetProperty(ref _despawn, value);
		}

		[Ordinal(3)] 
		[RED("makePlayerActiveVehicle")] 
		public CBool MakePlayerActiveVehicle
		{
			get => GetProperty(ref _makePlayerActiveVehicle);
			set => SetProperty(ref _makePlayerActiveVehicle, value);
		}

		public questEnablePlayerVehicle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
