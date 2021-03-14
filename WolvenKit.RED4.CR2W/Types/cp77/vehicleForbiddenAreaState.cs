using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleForbiddenAreaState : CVariable
	{
		private CUInt64 _globalNodeIDHash;
		private CBool _enabled;
		private CBool _dismount;

		[Ordinal(0)] 
		[RED("globalNodeIDHash")] 
		public CUInt64 GlobalNodeIDHash
		{
			get
			{
				if (_globalNodeIDHash == null)
				{
					_globalNodeIDHash = (CUInt64) CR2WTypeManager.Create("Uint64", "globalNodeIDHash", cr2w, this);
				}
				return _globalNodeIDHash;
			}
			set
			{
				if (_globalNodeIDHash == value)
				{
					return;
				}
				_globalNodeIDHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("dismount")] 
		public CBool Dismount
		{
			get
			{
				if (_dismount == null)
				{
					_dismount = (CBool) CR2WTypeManager.Create("Bool", "dismount", cr2w, this);
				}
				return _dismount;
			}
			set
			{
				if (_dismount == value)
				{
					return;
				}
				_dismount = value;
				PropertySet(this);
			}
		}

		public vehicleForbiddenAreaState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
