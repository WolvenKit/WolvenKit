using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleGridDestruction : audioAudioMetadata
	{
		private CFloat _minGridCellRawChangeThreshold;
		private CFloat _specificGridCellImpactCooldown;
		private CFloat _minGridCellValueToPlayDetailedEvent;
		private audioVehicleDestructionGridLayer _bottomLayer;
		private audioVehicleDestructionGridLayer _upperLayer;

		[Ordinal(1)] 
		[RED("minGridCellRawChangeThreshold")] 
		public CFloat MinGridCellRawChangeThreshold
		{
			get
			{
				if (_minGridCellRawChangeThreshold == null)
				{
					_minGridCellRawChangeThreshold = (CFloat) CR2WTypeManager.Create("Float", "minGridCellRawChangeThreshold", cr2w, this);
				}
				return _minGridCellRawChangeThreshold;
			}
			set
			{
				if (_minGridCellRawChangeThreshold == value)
				{
					return;
				}
				_minGridCellRawChangeThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("specificGridCellImpactCooldown")] 
		public CFloat SpecificGridCellImpactCooldown
		{
			get
			{
				if (_specificGridCellImpactCooldown == null)
				{
					_specificGridCellImpactCooldown = (CFloat) CR2WTypeManager.Create("Float", "specificGridCellImpactCooldown", cr2w, this);
				}
				return _specificGridCellImpactCooldown;
			}
			set
			{
				if (_specificGridCellImpactCooldown == value)
				{
					return;
				}
				_specificGridCellImpactCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("minGridCellValueToPlayDetailedEvent")] 
		public CFloat MinGridCellValueToPlayDetailedEvent
		{
			get
			{
				if (_minGridCellValueToPlayDetailedEvent == null)
				{
					_minGridCellValueToPlayDetailedEvent = (CFloat) CR2WTypeManager.Create("Float", "minGridCellValueToPlayDetailedEvent", cr2w, this);
				}
				return _minGridCellValueToPlayDetailedEvent;
			}
			set
			{
				if (_minGridCellValueToPlayDetailedEvent == value)
				{
					return;
				}
				_minGridCellValueToPlayDetailedEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bottomLayer")] 
		public audioVehicleDestructionGridLayer BottomLayer
		{
			get
			{
				if (_bottomLayer == null)
				{
					_bottomLayer = (audioVehicleDestructionGridLayer) CR2WTypeManager.Create("audioVehicleDestructionGridLayer", "bottomLayer", cr2w, this);
				}
				return _bottomLayer;
			}
			set
			{
				if (_bottomLayer == value)
				{
					return;
				}
				_bottomLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("upperLayer")] 
		public audioVehicleDestructionGridLayer UpperLayer
		{
			get
			{
				if (_upperLayer == null)
				{
					_upperLayer = (audioVehicleDestructionGridLayer) CR2WTypeManager.Create("audioVehicleDestructionGridLayer", "upperLayer", cr2w, this);
				}
				return _upperLayer;
			}
			set
			{
				if (_upperLayer == value)
				{
					return;
				}
				_upperLayer = value;
				PropertySet(this);
			}
		}

		public audioVehicleGridDestruction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
