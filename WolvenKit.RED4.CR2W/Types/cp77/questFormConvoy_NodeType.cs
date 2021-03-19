using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFormConvoy_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _leaderRef;
		private CEnum<vehicleFormationType> _formationType;

		[Ordinal(0)] 
		[RED("leaderRef")] 
		public gameEntityReference LeaderRef
		{
			get => GetProperty(ref _leaderRef);
			set => SetProperty(ref _leaderRef, value);
		}

		[Ordinal(1)] 
		[RED("formationType")] 
		public CEnum<vehicleFormationType> FormationType
		{
			get => GetProperty(ref _formationType);
			set => SetProperty(ref _formationType, value);
		}

		public questFormConvoy_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
