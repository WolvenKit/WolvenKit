using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDestructionPSData : CVariable
	{
		private CArrayFixedSize<CFloat> _gridValues;
		private CUInt32 _brokenGlass;
		private CUInt32 _brokenLights;
		private CUInt8 _flatTire;
		private CBool _windshieldShattered;
		private CArray<Vector3> _windshieldPoints;
		private CArray<CName> _detachedParts;

		[Ordinal(0)] 
		[RED("gridValues", 30)] 
		public CArrayFixedSize<CFloat> GridValues
		{
			get
			{
				if (_gridValues == null)
				{
					_gridValues = (CArrayFixedSize<CFloat>) CR2WTypeManager.Create("[30]Float", "gridValues", cr2w, this);
				}
				return _gridValues;
			}
			set
			{
				if (_gridValues == value)
				{
					return;
				}
				_gridValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("brokenGlass")] 
		public CUInt32 BrokenGlass
		{
			get
			{
				if (_brokenGlass == null)
				{
					_brokenGlass = (CUInt32) CR2WTypeManager.Create("Uint32", "brokenGlass", cr2w, this);
				}
				return _brokenGlass;
			}
			set
			{
				if (_brokenGlass == value)
				{
					return;
				}
				_brokenGlass = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("brokenLights")] 
		public CUInt32 BrokenLights
		{
			get
			{
				if (_brokenLights == null)
				{
					_brokenLights = (CUInt32) CR2WTypeManager.Create("Uint32", "brokenLights", cr2w, this);
				}
				return _brokenLights;
			}
			set
			{
				if (_brokenLights == value)
				{
					return;
				}
				_brokenLights = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("flatTire")] 
		public CUInt8 FlatTire
		{
			get
			{
				if (_flatTire == null)
				{
					_flatTire = (CUInt8) CR2WTypeManager.Create("Uint8", "flatTire", cr2w, this);
				}
				return _flatTire;
			}
			set
			{
				if (_flatTire == value)
				{
					return;
				}
				_flatTire = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("windshieldShattered")] 
		public CBool WindshieldShattered
		{
			get
			{
				if (_windshieldShattered == null)
				{
					_windshieldShattered = (CBool) CR2WTypeManager.Create("Bool", "windshieldShattered", cr2w, this);
				}
				return _windshieldShattered;
			}
			set
			{
				if (_windshieldShattered == value)
				{
					return;
				}
				_windshieldShattered = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("windshieldPoints")] 
		public CArray<Vector3> WindshieldPoints
		{
			get
			{
				if (_windshieldPoints == null)
				{
					_windshieldPoints = (CArray<Vector3>) CR2WTypeManager.Create("array:Vector3", "windshieldPoints", cr2w, this);
				}
				return _windshieldPoints;
			}
			set
			{
				if (_windshieldPoints == value)
				{
					return;
				}
				_windshieldPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("detachedParts")] 
		public CArray<CName> DetachedParts
		{
			get
			{
				if (_detachedParts == null)
				{
					_detachedParts = (CArray<CName>) CR2WTypeManager.Create("array:CName", "detachedParts", cr2w, this);
				}
				return _detachedParts;
			}
			set
			{
				if (_detachedParts == value)
				{
					return;
				}
				_detachedParts = value;
				PropertySet(this);
			}
		}

		public vehicleDestructionPSData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
