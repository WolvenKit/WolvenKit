using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPreviewGameController : gameuiMenuGameController
	{
		private CFloat _yawSpeed;
		private CFloat _yawDefault;
		private CBool _isRotatable;

		[Ordinal(3)] 
		[RED("yawSpeed")] 
		public CFloat YawSpeed
		{
			get
			{
				if (_yawSpeed == null)
				{
					_yawSpeed = (CFloat) CR2WTypeManager.Create("Float", "yawSpeed", cr2w, this);
				}
				return _yawSpeed;
			}
			set
			{
				if (_yawSpeed == value)
				{
					return;
				}
				_yawSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("yawDefault")] 
		public CFloat YawDefault
		{
			get
			{
				if (_yawDefault == null)
				{
					_yawDefault = (CFloat) CR2WTypeManager.Create("Float", "yawDefault", cr2w, this);
				}
				return _yawDefault;
			}
			set
			{
				if (_yawDefault == value)
				{
					return;
				}
				_yawDefault = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isRotatable")] 
		public CBool IsRotatable
		{
			get
			{
				if (_isRotatable == null)
				{
					_isRotatable = (CBool) CR2WTypeManager.Create("Bool", "isRotatable", cr2w, this);
				}
				return _isRotatable;
			}
			set
			{
				if (_isRotatable == value)
				{
					return;
				}
				_isRotatable = value;
				PropertySet(this);
			}
		}

		public gameuiPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
