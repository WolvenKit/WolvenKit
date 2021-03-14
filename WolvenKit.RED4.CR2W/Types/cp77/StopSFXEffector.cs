using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StopSFXEffector : gameEffector
	{
		private CName _sfxName;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("sfxName")] 
		public CName SfxName
		{
			get
			{
				if (_sfxName == null)
				{
					_sfxName = (CName) CR2WTypeManager.Create("CName", "sfxName", cr2w, this);
				}
				return _sfxName;
			}
			set
			{
				if (_sfxName == value)
				{
					return;
				}
				_sfxName = value;
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

		public StopSFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
