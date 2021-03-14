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
			get
			{
				if (_innerAreaBoundToOuterArea == null)
				{
					_innerAreaBoundToOuterArea = (CBool) CR2WTypeManager.Create("Bool", "innerAreaBoundToOuterArea", cr2w, this);
				}
				return _innerAreaBoundToOuterArea;
			}
			set
			{
				if (_innerAreaBoundToOuterArea == value)
				{
					return;
				}
				_innerAreaBoundToOuterArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("innerAreaOutline")] 
		public CHandle<AreaShapeOutline> InnerAreaOutline
		{
			get
			{
				if (_innerAreaOutline == null)
				{
					_innerAreaOutline = (CHandle<AreaShapeOutline>) CR2WTypeManager.Create("handle:AreaShapeOutline", "innerAreaOutline", cr2w, this);
				}
				return _innerAreaOutline;
			}
			set
			{
				if (_innerAreaOutline == value)
				{
					return;
				}
				_innerAreaOutline = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("parkingSpots")] 
		public CArray<NodeRef> ParkingSpots
		{
			get
			{
				if (_parkingSpots == null)
				{
					_parkingSpots = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "parkingSpots", cr2w, this);
				}
				return _parkingSpots;
			}
			set
			{
				if (_parkingSpots == value)
				{
					return;
				}
				_parkingSpots = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("innerAreaSpeedLimit")] 
		public CFloat InnerAreaSpeedLimit
		{
			get
			{
				if (_innerAreaSpeedLimit == null)
				{
					_innerAreaSpeedLimit = (CFloat) CR2WTypeManager.Create("Float", "innerAreaSpeedLimit", cr2w, this);
				}
				return _innerAreaSpeedLimit;
			}
			set
			{
				if (_innerAreaSpeedLimit == value)
				{
					return;
				}
				_innerAreaSpeedLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("areaSpeedLimit")] 
		public CFloat AreaSpeedLimit
		{
			get
			{
				if (_areaSpeedLimit == null)
				{
					_areaSpeedLimit = (CFloat) CR2WTypeManager.Create("Float", "areaSpeedLimit", cr2w, this);
				}
				return _areaSpeedLimit;
			}
			set
			{
				if (_areaSpeedLimit == value)
				{
					return;
				}
				_areaSpeedLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("enableNullArea")] 
		public CBool EnableNullArea
		{
			get
			{
				if (_enableNullArea == null)
				{
					_enableNullArea = (CBool) CR2WTypeManager.Create("Bool", "enableNullArea", cr2w, this);
				}
				return _enableNullArea;
			}
			set
			{
				if (_enableNullArea == value)
				{
					return;
				}
				_enableNullArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("dismount")] 
		public CBool Dismount
		{
			get
			{
				if (_dismount == null)
				{
					_dismount = (CBool) CR2WTypeManager.Create("Bool", "dismount", cr2w, this);
				}
				return _dismount;
			}
			set
			{
				if (_dismount == value)
				{
					return;
				}
				_dismount = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("enableSummoning")] 
		public CBool EnableSummoning
		{
			get
			{
				if (_enableSummoning == null)
				{
					_enableSummoning = (CBool) CR2WTypeManager.Create("Bool", "enableSummoning", cr2w, this);
				}
				return _enableSummoning;
			}
			set
			{
				if (_enableSummoning == value)
				{
					return;
				}
				_enableSummoning = value;
				PropertySet(this);
			}
		}

		public worldVehicleForbiddenAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
