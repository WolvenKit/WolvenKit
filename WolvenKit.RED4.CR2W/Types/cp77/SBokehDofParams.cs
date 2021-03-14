using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBokehDofParams : CVariable
	{
		private CBool _enabled;
		private CFloat _hexToCircleScale;
		private CBool _usePhysicalSetup;
		private CFloat _planeInFocus;
		private CEnum<EApertureValue> _fStops;
		private CFloat _bokehSizeMuliplier;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hexToCircleScale")] 
		public CFloat HexToCircleScale
		{
			get
			{
				if (_hexToCircleScale == null)
				{
					_hexToCircleScale = (CFloat) CR2WTypeManager.Create("Float", "hexToCircleScale", cr2w, this);
				}
				return _hexToCircleScale;
			}
			set
			{
				if (_hexToCircleScale == value)
				{
					return;
				}
				_hexToCircleScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("usePhysicalSetup")] 
		public CBool UsePhysicalSetup
		{
			get
			{
				if (_usePhysicalSetup == null)
				{
					_usePhysicalSetup = (CBool) CR2WTypeManager.Create("Bool", "usePhysicalSetup", cr2w, this);
				}
				return _usePhysicalSetup;
			}
			set
			{
				if (_usePhysicalSetup == value)
				{
					return;
				}
				_usePhysicalSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("planeInFocus")] 
		public CFloat PlaneInFocus
		{
			get
			{
				if (_planeInFocus == null)
				{
					_planeInFocus = (CFloat) CR2WTypeManager.Create("Float", "planeInFocus", cr2w, this);
				}
				return _planeInFocus;
			}
			set
			{
				if (_planeInFocus == value)
				{
					return;
				}
				_planeInFocus = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("fStops")] 
		public CEnum<EApertureValue> FStops
		{
			get
			{
				if (_fStops == null)
				{
					_fStops = (CEnum<EApertureValue>) CR2WTypeManager.Create("EApertureValue", "fStops", cr2w, this);
				}
				return _fStops;
			}
			set
			{
				if (_fStops == value)
				{
					return;
				}
				_fStops = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bokehSizeMuliplier")] 
		public CFloat BokehSizeMuliplier
		{
			get
			{
				if (_bokehSizeMuliplier == null)
				{
					_bokehSizeMuliplier = (CFloat) CR2WTypeManager.Create("Float", "bokehSizeMuliplier", cr2w, this);
				}
				return _bokehSizeMuliplier;
			}
			set
			{
				if (_bokehSizeMuliplier == value)
				{
					return;
				}
				_bokehSizeMuliplier = value;
				PropertySet(this);
			}
		}

		public SBokehDofParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
