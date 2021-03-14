using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrafficLight : Device
	{
		private CEnum<worldTrafficLightColor> _lightState;
		private CHandle<entPhysicalMeshComponent> _trafficLightMesh;
		private CHandle<entPhysicalMeshComponent> _destroyedMesh;

		[Ordinal(86)] 
		[RED("lightState")] 
		public CEnum<worldTrafficLightColor> LightState
		{
			get
			{
				if (_lightState == null)
				{
					_lightState = (CEnum<worldTrafficLightColor>) CR2WTypeManager.Create("worldTrafficLightColor", "lightState", cr2w, this);
				}
				return _lightState;
			}
			set
			{
				if (_lightState == value)
				{
					return;
				}
				_lightState = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("trafficLightMesh")] 
		public CHandle<entPhysicalMeshComponent> TrafficLightMesh
		{
			get
			{
				if (_trafficLightMesh == null)
				{
					_trafficLightMesh = (CHandle<entPhysicalMeshComponent>) CR2WTypeManager.Create("handle:entPhysicalMeshComponent", "trafficLightMesh", cr2w, this);
				}
				return _trafficLightMesh;
			}
			set
			{
				if (_trafficLightMesh == value)
				{
					return;
				}
				_trafficLightMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(88)] 
		[RED("destroyedMesh")] 
		public CHandle<entPhysicalMeshComponent> DestroyedMesh
		{
			get
			{
				if (_destroyedMesh == null)
				{
					_destroyedMesh = (CHandle<entPhysicalMeshComponent>) CR2WTypeManager.Create("handle:entPhysicalMeshComponent", "destroyedMesh", cr2w, this);
				}
				return _destroyedMesh;
			}
			set
			{
				if (_destroyedMesh == value)
				{
					return;
				}
				_destroyedMesh = value;
				PropertySet(this);
			}
		}

		public TrafficLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
