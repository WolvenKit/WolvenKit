using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animfssBodyOfflineParams : CVariable
	{
		private CFloat _hipsTilt;
		private CFloat _hipsShift;
		private CFloat _legsPullFactorMin;
		private CFloat _legsPullFactorMax;
		private CFloat _legLengthAdjustment;
		private CFloat _legMaxStretchOffset;
		private CFloat _legMaxStretchAdjustment;

		[Ordinal(0)] 
		[RED("HipsTilt")] 
		public CFloat HipsTilt
		{
			get
			{
				if (_hipsTilt == null)
				{
					_hipsTilt = (CFloat) CR2WTypeManager.Create("Float", "HipsTilt", cr2w, this);
				}
				return _hipsTilt;
			}
			set
			{
				if (_hipsTilt == value)
				{
					return;
				}
				_hipsTilt = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("HipsShift")] 
		public CFloat HipsShift
		{
			get
			{
				if (_hipsShift == null)
				{
					_hipsShift = (CFloat) CR2WTypeManager.Create("Float", "HipsShift", cr2w, this);
				}
				return _hipsShift;
			}
			set
			{
				if (_hipsShift == value)
				{
					return;
				}
				_hipsShift = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("LegsPullFactorMin")] 
		public CFloat LegsPullFactorMin
		{
			get
			{
				if (_legsPullFactorMin == null)
				{
					_legsPullFactorMin = (CFloat) CR2WTypeManager.Create("Float", "LegsPullFactorMin", cr2w, this);
				}
				return _legsPullFactorMin;
			}
			set
			{
				if (_legsPullFactorMin == value)
				{
					return;
				}
				_legsPullFactorMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("LegsPullFactorMax")] 
		public CFloat LegsPullFactorMax
		{
			get
			{
				if (_legsPullFactorMax == null)
				{
					_legsPullFactorMax = (CFloat) CR2WTypeManager.Create("Float", "LegsPullFactorMax", cr2w, this);
				}
				return _legsPullFactorMax;
			}
			set
			{
				if (_legsPullFactorMax == value)
				{
					return;
				}
				_legsPullFactorMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("LegLengthAdjustment")] 
		public CFloat LegLengthAdjustment
		{
			get
			{
				if (_legLengthAdjustment == null)
				{
					_legLengthAdjustment = (CFloat) CR2WTypeManager.Create("Float", "LegLengthAdjustment", cr2w, this);
				}
				return _legLengthAdjustment;
			}
			set
			{
				if (_legLengthAdjustment == value)
				{
					return;
				}
				_legLengthAdjustment = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("LegMaxStretchOffset")] 
		public CFloat LegMaxStretchOffset
		{
			get
			{
				if (_legMaxStretchOffset == null)
				{
					_legMaxStretchOffset = (CFloat) CR2WTypeManager.Create("Float", "LegMaxStretchOffset", cr2w, this);
				}
				return _legMaxStretchOffset;
			}
			set
			{
				if (_legMaxStretchOffset == value)
				{
					return;
				}
				_legMaxStretchOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("LegMaxStretchAdjustment")] 
		public CFloat LegMaxStretchAdjustment
		{
			get
			{
				if (_legMaxStretchAdjustment == null)
				{
					_legMaxStretchAdjustment = (CFloat) CR2WTypeManager.Create("Float", "LegMaxStretchAdjustment", cr2w, this);
				}
				return _legMaxStretchAdjustment;
			}
			set
			{
				if (_legMaxStretchAdjustment == value)
				{
					return;
				}
				_legMaxStretchAdjustment = value;
				PropertySet(this);
			}
		}

		public animfssBodyOfflineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
