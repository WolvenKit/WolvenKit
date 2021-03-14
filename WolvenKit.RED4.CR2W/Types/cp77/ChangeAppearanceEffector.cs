using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeAppearanceEffector : gameEffector
	{
		private CName _appearanceName;
		private CBool _resetAppearance;
		private CName _previousAppearance;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get
			{
				if (_appearanceName == null)
				{
					_appearanceName = (CName) CR2WTypeManager.Create("CName", "appearanceName", cr2w, this);
				}
				return _appearanceName;
			}
			set
			{
				if (_appearanceName == value)
				{
					return;
				}
				_appearanceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("resetAppearance")] 
		public CBool ResetAppearance
		{
			get
			{
				if (_resetAppearance == null)
				{
					_resetAppearance = (CBool) CR2WTypeManager.Create("Bool", "resetAppearance", cr2w, this);
				}
				return _resetAppearance;
			}
			set
			{
				if (_resetAppearance == value)
				{
					return;
				}
				_resetAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("previousAppearance")] 
		public CName PreviousAppearance
		{
			get
			{
				if (_previousAppearance == null)
				{
					_previousAppearance = (CName) CR2WTypeManager.Create("CName", "previousAppearance", cr2w, this);
				}
				return _previousAppearance;
			}
			set
			{
				if (_previousAppearance == value)
				{
					return;
				}
				_previousAppearance = value;
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

		public ChangeAppearanceEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
