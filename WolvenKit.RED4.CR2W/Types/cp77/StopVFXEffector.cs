using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StopVFXEffector : gameEffector
	{
		private CName _vfxName;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("vfxName")] 
		public CName VfxName
		{
			get
			{
				if (_vfxName == null)
				{
					_vfxName = (CName) CR2WTypeManager.Create("CName", "vfxName", cr2w, this);
				}
				return _vfxName;
			}
			set
			{
				if (_vfxName == value)
				{
					return;
				}
				_vfxName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		public StopVFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
