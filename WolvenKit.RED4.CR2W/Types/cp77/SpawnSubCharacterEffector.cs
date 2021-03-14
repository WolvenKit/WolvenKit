using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpawnSubCharacterEffector : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private TweakDBID _subCharacterTDBID;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("subCharacterTDBID")] 
		public TweakDBID SubCharacterTDBID
		{
			get
			{
				if (_subCharacterTDBID == null)
				{
					_subCharacterTDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "subCharacterTDBID", cr2w, this);
				}
				return _subCharacterTDBID;
			}
			set
			{
				if (_subCharacterTDBID == value)
				{
					return;
				}
				_subCharacterTDBID = value;
				PropertySet(this);
			}
		}

		public SpawnSubCharacterEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
