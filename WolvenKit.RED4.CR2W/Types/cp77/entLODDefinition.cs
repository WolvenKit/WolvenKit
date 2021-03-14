using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLODDefinition : ISerializable
	{
		private CStatic<CFloat> _backgroundDistanceLODs;
		private CStatic<CFloat> _regularDistanceLODs;
		private CStatic<CFloat> _cinematicDistanceLODs;
		private CStatic<CFloat> _vehicleDistanceLODs;
		private CStatic<CFloat> _cinematicVehicleDistanceLODs;

		[Ordinal(0)] 
		[RED("backgroundDistanceLODs", 4)] 
		public CStatic<CFloat> BackgroundDistanceLODs
		{
			get
			{
				if (_backgroundDistanceLODs == null)
				{
					_backgroundDistanceLODs = (CStatic<CFloat>) CR2WTypeManager.Create("static:4,Float", "backgroundDistanceLODs", cr2w, this);
				}
				return _backgroundDistanceLODs;
			}
			set
			{
				if (_backgroundDistanceLODs == value)
				{
					return;
				}
				_backgroundDistanceLODs = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("regularDistanceLODs", 4)] 
		public CStatic<CFloat> RegularDistanceLODs
		{
			get
			{
				if (_regularDistanceLODs == null)
				{
					_regularDistanceLODs = (CStatic<CFloat>) CR2WTypeManager.Create("static:4,Float", "regularDistanceLODs", cr2w, this);
				}
				return _regularDistanceLODs;
			}
			set
			{
				if (_regularDistanceLODs == value)
				{
					return;
				}
				_regularDistanceLODs = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cinematicDistanceLODs", 4)] 
		public CStatic<CFloat> CinematicDistanceLODs
		{
			get
			{
				if (_cinematicDistanceLODs == null)
				{
					_cinematicDistanceLODs = (CStatic<CFloat>) CR2WTypeManager.Create("static:4,Float", "cinematicDistanceLODs", cr2w, this);
				}
				return _cinematicDistanceLODs;
			}
			set
			{
				if (_cinematicDistanceLODs == value)
				{
					return;
				}
				_cinematicDistanceLODs = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("vehicleDistanceLODs", 4)] 
		public CStatic<CFloat> VehicleDistanceLODs
		{
			get
			{
				if (_vehicleDistanceLODs == null)
				{
					_vehicleDistanceLODs = (CStatic<CFloat>) CR2WTypeManager.Create("static:4,Float", "vehicleDistanceLODs", cr2w, this);
				}
				return _vehicleDistanceLODs;
			}
			set
			{
				if (_vehicleDistanceLODs == value)
				{
					return;
				}
				_vehicleDistanceLODs = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("cinematicVehicleDistanceLODs", 4)] 
		public CStatic<CFloat> CinematicVehicleDistanceLODs
		{
			get
			{
				if (_cinematicVehicleDistanceLODs == null)
				{
					_cinematicVehicleDistanceLODs = (CStatic<CFloat>) CR2WTypeManager.Create("static:4,Float", "cinematicVehicleDistanceLODs", cr2w, this);
				}
				return _cinematicVehicleDistanceLODs;
			}
			set
			{
				if (_cinematicVehicleDistanceLODs == value)
				{
					return;
				}
				_cinematicVehicleDistanceLODs = value;
				PropertySet(this);
			}
		}

		public entLODDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
