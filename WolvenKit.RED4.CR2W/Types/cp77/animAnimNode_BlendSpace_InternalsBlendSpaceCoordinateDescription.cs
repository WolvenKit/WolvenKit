using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription : CVariable
	{
		private CName _name;
		private CFloat _minValue;
		private CFloat _maxValue;
		private CUInt32 _gridDivisionsCount;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
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

		[Ordinal(1)] 
		[RED("minValue")] 
		public CFloat MinValue
		{
			get
			{
				if (_minValue == null)
				{
					_minValue = (CFloat) CR2WTypeManager.Create("Float", "minValue", cr2w, this);
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
		public CFloat MaxValue
		{
			get
			{
				if (_maxValue == null)
				{
					_maxValue = (CFloat) CR2WTypeManager.Create("Float", "maxValue", cr2w, this);
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
		[RED("gridDivisionsCount")] 
		public CUInt32 GridDivisionsCount
		{
			get
			{
				if (_gridDivisionsCount == null)
				{
					_gridDivisionsCount = (CUInt32) CR2WTypeManager.Create("Uint32", "gridDivisionsCount", cr2w, this);
				}
				return _gridDivisionsCount;
			}
			set
			{
				if (_gridDivisionsCount == value)
				{
					return;
				}
				_gridDivisionsCount = value;
				PropertySet(this);
			}
		}

		public animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
