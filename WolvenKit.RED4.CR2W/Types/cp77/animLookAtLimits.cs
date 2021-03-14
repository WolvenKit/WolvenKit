using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtLimits : CVariable
	{
		private CFloat _softLimitDegrees;
		private CFloat _hardLimitDegrees;
		private CFloat _hardLimitDistance;
		private CFloat _backLimitDegrees;

		[Ordinal(0)] 
		[RED("softLimitDegrees")] 
		public CFloat SoftLimitDegrees
		{
			get
			{
				if (_softLimitDegrees == null)
				{
					_softLimitDegrees = (CFloat) CR2WTypeManager.Create("Float", "softLimitDegrees", cr2w, this);
				}
				return _softLimitDegrees;
			}
			set
			{
				if (_softLimitDegrees == value)
				{
					return;
				}
				_softLimitDegrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hardLimitDegrees")] 
		public CFloat HardLimitDegrees
		{
			get
			{
				if (_hardLimitDegrees == null)
				{
					_hardLimitDegrees = (CFloat) CR2WTypeManager.Create("Float", "hardLimitDegrees", cr2w, this);
				}
				return _hardLimitDegrees;
			}
			set
			{
				if (_hardLimitDegrees == value)
				{
					return;
				}
				_hardLimitDegrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hardLimitDistance")] 
		public CFloat HardLimitDistance
		{
			get
			{
				if (_hardLimitDistance == null)
				{
					_hardLimitDistance = (CFloat) CR2WTypeManager.Create("Float", "hardLimitDistance", cr2w, this);
				}
				return _hardLimitDistance;
			}
			set
			{
				if (_hardLimitDistance == value)
				{
					return;
				}
				_hardLimitDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("backLimitDegrees")] 
		public CFloat BackLimitDegrees
		{
			get
			{
				if (_backLimitDegrees == null)
				{
					_backLimitDegrees = (CFloat) CR2WTypeManager.Create("Float", "backLimitDegrees", cr2w, this);
				}
				return _backLimitDegrees;
			}
			set
			{
				if (_backLimitDegrees == value)
				{
					return;
				}
				_backLimitDegrees = value;
				PropertySet(this);
			}
		}

		public animLookAtLimits(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
