using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netIEntityState : CVariable
	{
		private TweakDBID _recordID;
		private CUInt64 _persistentID;

		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get
			{
				if (_recordID == null)
				{
					_recordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "recordID", cr2w, this);
				}
				return _recordID;
			}
			set
			{
				if (_recordID == value)
				{
					return;
				}
				_recordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("persistentID")] 
		public CUInt64 PersistentID
		{
			get
			{
				if (_persistentID == null)
				{
					_persistentID = (CUInt64) CR2WTypeManager.Create("Uint64", "persistentID", cr2w, this);
				}
				return _persistentID;
			}
			set
			{
				if (_persistentID == value)
				{
					return;
				}
				_persistentID = value;
				PropertySet(this);
			}
		}

		public netIEntityState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
