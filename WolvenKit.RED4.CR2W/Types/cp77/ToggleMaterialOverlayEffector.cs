using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleMaterialOverlayEffector : gameEffector
	{
		private CString _effectPath;
		private CName _effectTag;
		private CHandle<gameEffectInstance> _effectInstance;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("effectPath")] 
		public CString EffectPath
		{
			get
			{
				if (_effectPath == null)
				{
					_effectPath = (CString) CR2WTypeManager.Create("String", "effectPath", cr2w, this);
				}
				return _effectPath;
			}
			set
			{
				if (_effectPath == value)
				{
					return;
				}
				_effectPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get
			{
				if (_effectTag == null)
				{
					_effectTag = (CName) CR2WTypeManager.Create("CName", "effectTag", cr2w, this);
				}
				return _effectTag;
			}
			set
			{
				if (_effectTag == value)
				{
					return;
				}
				_effectTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get
			{
				if (_effectInstance == null)
				{
					_effectInstance = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "effectInstance", cr2w, this);
				}
				return _effectInstance;
			}
			set
			{
				if (_effectInstance == value)
				{
					return;
				}
				_effectInstance = value;
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

		public ToggleMaterialOverlayEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
