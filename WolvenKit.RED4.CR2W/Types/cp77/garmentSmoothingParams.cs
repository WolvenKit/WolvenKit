using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class garmentSmoothingParams : CVariable
	{
		private CFloat _smoothingStrength;
		private CFloat _smoothingRadiusInCM;
		private CFloat _smoothingExponent;
		private CUInt32 _smoothingNumNeighbours;

		[Ordinal(0)] 
		[RED("smoothingStrength")] 
		public CFloat SmoothingStrength
		{
			get
			{
				if (_smoothingStrength == null)
				{
					_smoothingStrength = (CFloat) CR2WTypeManager.Create("Float", "smoothingStrength", cr2w, this);
				}
				return _smoothingStrength;
			}
			set
			{
				if (_smoothingStrength == value)
				{
					return;
				}
				_smoothingStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("smoothingRadiusInCM")] 
		public CFloat SmoothingRadiusInCM
		{
			get
			{
				if (_smoothingRadiusInCM == null)
				{
					_smoothingRadiusInCM = (CFloat) CR2WTypeManager.Create("Float", "smoothingRadiusInCM", cr2w, this);
				}
				return _smoothingRadiusInCM;
			}
			set
			{
				if (_smoothingRadiusInCM == value)
				{
					return;
				}
				_smoothingRadiusInCM = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("smoothingExponent")] 
		public CFloat SmoothingExponent
		{
			get
			{
				if (_smoothingExponent == null)
				{
					_smoothingExponent = (CFloat) CR2WTypeManager.Create("Float", "smoothingExponent", cr2w, this);
				}
				return _smoothingExponent;
			}
			set
			{
				if (_smoothingExponent == value)
				{
					return;
				}
				_smoothingExponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("smoothingNumNeighbours")] 
		public CUInt32 SmoothingNumNeighbours
		{
			get
			{
				if (_smoothingNumNeighbours == null)
				{
					_smoothingNumNeighbours = (CUInt32) CR2WTypeManager.Create("Uint32", "smoothingNumNeighbours", cr2w, this);
				}
				return _smoothingNumNeighbours;
			}
			set
			{
				if (_smoothingNumNeighbours == value)
				{
					return;
				}
				_smoothingNumNeighbours = value;
				PropertySet(this);
			}
		}

		public garmentSmoothingParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
