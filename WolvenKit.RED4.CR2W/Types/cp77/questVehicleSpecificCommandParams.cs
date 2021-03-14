using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleSpecificCommandParams : ISerializable
	{
		private CBool _pushOtherVehiclesAside;
		private CBool _needDriver;
		private CFloat _secureTimeOut;

		[Ordinal(0)] 
		[RED("pushOtherVehiclesAside")] 
		public CBool PushOtherVehiclesAside
		{
			get
			{
				if (_pushOtherVehiclesAside == null)
				{
					_pushOtherVehiclesAside = (CBool) CR2WTypeManager.Create("Bool", "pushOtherVehiclesAside", cr2w, this);
				}
				return _pushOtherVehiclesAside;
			}
			set
			{
				if (_pushOtherVehiclesAside == value)
				{
					return;
				}
				_pushOtherVehiclesAside = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("needDriver")] 
		public CBool NeedDriver
		{
			get
			{
				if (_needDriver == null)
				{
					_needDriver = (CBool) CR2WTypeManager.Create("Bool", "needDriver", cr2w, this);
				}
				return _needDriver;
			}
			set
			{
				if (_needDriver == value)
				{
					return;
				}
				_needDriver = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("secureTimeOut")] 
		public CFloat SecureTimeOut
		{
			get
			{
				if (_secureTimeOut == null)
				{
					_secureTimeOut = (CFloat) CR2WTypeManager.Create("Float", "secureTimeOut", cr2w, this);
				}
				return _secureTimeOut;
			}
			set
			{
				if (_secureTimeOut == value)
				{
					return;
				}
				_secureTimeOut = value;
				PropertySet(this);
			}
		}

		public questVehicleSpecificCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
