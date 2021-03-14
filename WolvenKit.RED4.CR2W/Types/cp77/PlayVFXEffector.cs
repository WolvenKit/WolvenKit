using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayVFXEffector : gameEffector
	{
		private CName _vfxName;
		private CBool _startOnUninitialize;
		private CBool _fireAndForget;
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
		[RED("startOnUninitialize")] 
		public CBool StartOnUninitialize
		{
			get
			{
				if (_startOnUninitialize == null)
				{
					_startOnUninitialize = (CBool) CR2WTypeManager.Create("Bool", "startOnUninitialize", cr2w, this);
				}
				return _startOnUninitialize;
			}
			set
			{
				if (_startOnUninitialize == value)
				{
					return;
				}
				_startOnUninitialize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fireAndForget")] 
		public CBool FireAndForget
		{
			get
			{
				if (_fireAndForget == null)
				{
					_fireAndForget = (CBool) CR2WTypeManager.Create("Bool", "fireAndForget", cr2w, this);
				}
				return _fireAndForget;
			}
			set
			{
				if (_fireAndForget == value)
				{
					return;
				}
				_fireAndForget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public PlayVFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
