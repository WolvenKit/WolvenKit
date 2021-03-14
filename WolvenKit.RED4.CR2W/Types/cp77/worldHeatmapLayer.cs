using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldHeatmapLayer : CResource
	{
		private CUInt32 _minValue;
		private CUInt32 _maxValue;
		private CString _name;
		private CString _units;
		private CBool _invert;

		[Ordinal(1)] 
		[RED("minValue")] 
		public CUInt32 MinValue
		{
			get
			{
				if (_minValue == null)
				{
					_minValue = (CUInt32) CR2WTypeManager.Create("Uint32", "minValue", cr2w, this);
				}
				return _minValue;
			}
			set
			{
				if (_minValue == value)
				{
					return;
				}
				_minValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxValue")] 
		public CUInt32 MaxValue
		{
			get
			{
				if (_maxValue == null)
				{
					_maxValue = (CUInt32) CR2WTypeManager.Create("Uint32", "maxValue", cr2w, this);
				}
				return _maxValue;
			}
			set
			{
				if (_maxValue == value)
				{
					return;
				}
				_maxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("name")] 
		public CString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CString) CR2WTypeManager.Create("String", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("units")] 
		public CString Units
		{
			get
			{
				if (_units == null)
				{
					_units = (CString) CR2WTypeManager.Create("String", "units", cr2w, this);
				}
				return _units;
			}
			set
			{
				if (_units == value)
				{
					return;
				}
				_units = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("invert")] 
		public CBool Invert
		{
			get
			{
				if (_invert == null)
				{
					_invert = (CBool) CR2WTypeManager.Create("Bool", "invert", cr2w, this);
				}
				return _invert;
			}
			set
			{
				if (_invert == value)
				{
					return;
				}
				_invert = value;
				PropertySet(this);
			}
		}

		public worldHeatmapLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
