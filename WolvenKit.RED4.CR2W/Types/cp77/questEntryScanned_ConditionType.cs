using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntryScanned_ConditionType : questIObjectConditionType
	{
		private gameEntityReference _objectRef;
		private TweakDBID _entryID;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entryID")] 
		public TweakDBID EntryID
		{
			get
			{
				if (_entryID == null)
				{
					_entryID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "entryID", cr2w, this);
				}
				return _entryID;
			}
			set
			{
				if (_entryID == value)
				{
					return;
				}
				_entryID = value;
				PropertySet(this);
			}
		}

		public questEntryScanned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
