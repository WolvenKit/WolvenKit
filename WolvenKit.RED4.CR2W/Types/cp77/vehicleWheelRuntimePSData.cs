using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleWheelRuntimePSData : CVariable
	{
		private CName _previousTouchedMaterial;
		private CFloat _previousVisualDisplacement;
		private CFloat _previousLogicalSpringCompression;
		private CFloat _previousSwaybarDisplacement;
		private CFloat _previousDampedSpringForce;

		[Ordinal(0)] 
		[RED("previousTouchedMaterial")] 
		public CName PreviousTouchedMaterial
		{
			get
			{
				if (_previousTouchedMaterial == null)
				{
					_previousTouchedMaterial = (CName) CR2WTypeManager.Create("CName", "previousTouchedMaterial", cr2w, this);
				}
				return _previousTouchedMaterial;
			}
			set
			{
				if (_previousTouchedMaterial == value)
				{
					return;
				}
				_previousTouchedMaterial = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("previousVisualDisplacement")] 
		public CFloat PreviousVisualDisplacement
		{
			get
			{
				if (_previousVisualDisplacement == null)
				{
					_previousVisualDisplacement = (CFloat) CR2WTypeManager.Create("Float", "previousVisualDisplacement", cr2w, this);
				}
				return _previousVisualDisplacement;
			}
			set
			{
				if (_previousVisualDisplacement == value)
				{
					return;
				}
				_previousVisualDisplacement = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("previousLogicalSpringCompression")] 
		public CFloat PreviousLogicalSpringCompression
		{
			get
			{
				if (_previousLogicalSpringCompression == null)
				{
					_previousLogicalSpringCompression = (CFloat) CR2WTypeManager.Create("Float", "previousLogicalSpringCompression", cr2w, this);
				}
				return _previousLogicalSpringCompression;
			}
			set
			{
				if (_previousLogicalSpringCompression == value)
				{
					return;
				}
				_previousLogicalSpringCompression = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("previousSwaybarDisplacement")] 
		public CFloat PreviousSwaybarDisplacement
		{
			get
			{
				if (_previousSwaybarDisplacement == null)
				{
					_previousSwaybarDisplacement = (CFloat) CR2WTypeManager.Create("Float", "previousSwaybarDisplacement", cr2w, this);
				}
				return _previousSwaybarDisplacement;
			}
			set
			{
				if (_previousSwaybarDisplacement == value)
				{
					return;
				}
				_previousSwaybarDisplacement = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("previousDampedSpringForce")] 
		public CFloat PreviousDampedSpringForce
		{
			get
			{
				if (_previousDampedSpringForce == null)
				{
					_previousDampedSpringForce = (CFloat) CR2WTypeManager.Create("Float", "previousDampedSpringForce", cr2w, this);
				}
				return _previousDampedSpringForce;
			}
			set
			{
				if (_previousDampedSpringForce == value)
				{
					return;
				}
				_previousDampedSpringForce = value;
				PropertySet(this);
			}
		}

		public vehicleWheelRuntimePSData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
