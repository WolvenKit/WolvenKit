using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldVehicleForbiddenAreaNotifier : worldITriggerAreaNotifer
	{
		private CBool _innerAreaBoundToOuterArea;
		private CHandle<AreaShapeOutline> _innerAreaOutline;
		private CArray<NodeRef> _parkingSpots;
		private CFloat _innerAreaSpeedLimit;
		private CFloat _areaSpeedLimit;
		private CBool _enableNullArea;
		private CBool _dismount;
		private CBool _enableSummoning;

		[Ordinal(3)] 
		[RED("innerAreaBoundToOuterArea")] 
		public CBool InnerAreaBoundToOuterArea
		{
			get => GetProperty(ref _innerAreaBoundToOuterArea);
			set => SetProperty(ref _innerAreaBoundToOuterArea, value);
		}

		[Ordinal(4)] 
		[RED("innerAreaOutline")] 
		public CHandle<AreaShapeOutline> InnerAreaOutline
		{
			get => GetProperty(ref _innerAreaOutline);
			set => SetProperty(ref _innerAreaOutline, value);
		}

		[Ordinal(5)] 
		[RED("parkingSpots")] 
		public CArray<NodeRef> ParkingSpots
		{
			get => GetProperty(ref _parkingSpots);
			set => SetProperty(ref _parkingSpots, value);
		}

		[Ordinal(6)] 
		[RED("innerAreaSpeedLimit")] 
		public CFloat InnerAreaSpeedLimit
		{
			get => GetProperty(ref _innerAreaSpeedLimit);
			set => SetProperty(ref _innerAreaSpeedLimit, value);
		}

		[Ordinal(7)] 
		[RED("areaSpeedLimit")] 
		public CFloat AreaSpeedLimit
		{
			get => GetProperty(ref _areaSpeedLimit);
			set => SetProperty(ref _areaSpeedLimit, value);
		}

		[Ordinal(8)] 
		[RED("enableNullArea")] 
		public CBool EnableNullArea
		{
			get => GetProperty(ref _enableNullArea);
			set => SetProperty(ref _enableNullArea, value);
		}

		[Ordinal(9)] 
		[RED("dismount")] 
		public CBool Dismount
		{
			get => GetProperty(ref _dismount);
			set => SetProperty(ref _dismount, value);
		}

		[Ordinal(10)] 
		[RED("enableSummoning")] 
		public CBool EnableSummoning
		{
			get => GetProperty(ref _enableSummoning);
			set => SetProperty(ref _enableSummoning, value);
		}

		public worldVehicleForbiddenAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
