using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StopAndPlayVFXEffector : gameEffector
	{
		private CName _vfxToStop;
		private CName _vfxToStart;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("vfxToStop")] 
		public CName VfxToStop
		{
			get
			{
				if (_vfxToStop == null)
				{
					_vfxToStop = (CName) CR2WTypeManager.Create("CName", "vfxToStop", cr2w, this);
				}
				return _vfxToStop;
			}
			set
			{
				if (_vfxToStop == value)
				{
					return;
				}
				_vfxToStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vfxToStart")] 
		public CName VfxToStart
		{
			get
			{
				if (_vfxToStart == null)
				{
					_vfxToStart = (CName) CR2WTypeManager.Create("CName", "vfxToStart", cr2w, this);
				}
				return _vfxToStart;
			}
			set
			{
				if (_vfxToStart == value)
				{
					return;
				}
				_vfxToStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public StopAndPlayVFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
