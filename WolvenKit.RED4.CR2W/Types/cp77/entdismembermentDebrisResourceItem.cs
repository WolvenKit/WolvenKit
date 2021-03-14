using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentDebrisResourceItem : CVariable
	{
		private rRef<animRig> _rig;
		private rRef<CMesh> _mesh;

		[Ordinal(0)] 
		[RED("rig")] 
		public rRef<animRig> Rig
		{
			get
			{
				if (_rig == null)
				{
					_rig = (rRef<animRig>) CR2WTypeManager.Create("rRef:animRig", "rig", cr2w, this);
				}
				return _rig;
			}
			set
			{
				if (_rig == value)
				{
					return;
				}
				_rig = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mesh")] 
		public rRef<CMesh> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (rRef<CMesh>) CR2WTypeManager.Create("rRef:CMesh", "mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		public entdismembermentDebrisResourceItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
