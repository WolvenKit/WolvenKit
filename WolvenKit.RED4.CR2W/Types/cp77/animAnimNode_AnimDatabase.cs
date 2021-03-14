using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AnimDatabase : animAnimNode_SkPhaseWithDurationAnim
	{
		private animAnimDatabaseCollectionEntry _animDataBase;
		private CArray<animIntLink> _inputLinks;

		[Ordinal(32)] 
		[RED("animDataBase")] 
		public animAnimDatabaseCollectionEntry AnimDataBase
		{
			get
			{
				if (_animDataBase == null)
				{
					_animDataBase = (animAnimDatabaseCollectionEntry) CR2WTypeManager.Create("animAnimDatabaseCollectionEntry", "animDataBase", cr2w, this);
				}
				return _animDataBase;
			}
			set
			{
				if (_animDataBase == value)
				{
					return;
				}
				_animDataBase = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("inputLinks")] 
		public CArray<animIntLink> InputLinks
		{
			get
			{
				if (_inputLinks == null)
				{
					_inputLinks = (CArray<animIntLink>) CR2WTypeManager.Create("array:animIntLink", "inputLinks", cr2w, this);
				}
				return _inputLinks;
			}
			set
			{
				if (_inputLinks == value)
				{
					return;
				}
				_inputLinks = value;
				PropertySet(this);
			}
		}

		public animAnimNode_AnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
