using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConnectedClassTypes : CVariable
	{
		private CBool _surveillanceCamera;
		private CBool _securityTurret;
		private CBool _puppet;

		[Ordinal(0)] 
		[RED("surveillanceCamera")] 
		public CBool SurveillanceCamera
		{
			get
			{
				if (_surveillanceCamera == null)
				{
					_surveillanceCamera = (CBool) CR2WTypeManager.Create("Bool", "surveillanceCamera", cr2w, this);
				}
				return _surveillanceCamera;
			}
			set
			{
				if (_surveillanceCamera == value)
				{
					return;
				}
				_surveillanceCamera = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("securityTurret")] 
		public CBool SecurityTurret
		{
			get
			{
				if (_securityTurret == null)
				{
					_securityTurret = (CBool) CR2WTypeManager.Create("Bool", "securityTurret", cr2w, this);
				}
				return _securityTurret;
			}
			set
			{
				if (_securityTurret == value)
				{
					return;
				}
				_securityTurret = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("puppet")] 
		public CBool Puppet
		{
			get
			{
				if (_puppet == null)
				{
					_puppet = (CBool) CR2WTypeManager.Create("Bool", "puppet", cr2w, this);
				}
				return _puppet;
			}
			set
			{
				if (_puppet == value)
				{
					return;
				}
				_puppet = value;
				PropertySet(this);
			}
		}

		public ConnectedClassTypes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
