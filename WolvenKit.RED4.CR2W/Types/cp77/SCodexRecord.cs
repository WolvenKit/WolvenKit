using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SCodexRecord : CVariable
	{
		private TweakDBID _recordID;
		private CArray<SCodexRecordPart> _recordContent;
		private CArray<CName> _tags;
		private CBool _unlocked;

		[Ordinal(0)] 
		[RED("RecordID")] 
		public TweakDBID RecordID
		{
			get
			{
				if (_recordID == null)
				{
					_recordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "RecordID", cr2w, this);
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
		[RED("RecordContent")] 
		public CArray<SCodexRecordPart> RecordContent
		{
			get
			{
				if (_recordContent == null)
				{
					_recordContent = (CArray<SCodexRecordPart>) CR2WTypeManager.Create("array:SCodexRecordPart", "RecordContent", cr2w, this);
				}
				return _recordContent;
			}
			set
			{
				if (_recordContent == value)
				{
					return;
				}
				_recordContent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Tags")] 
		public CArray<CName> Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "Tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Unlocked")] 
		public CBool Unlocked
		{
			get
			{
				if (_unlocked == null)
				{
					_unlocked = (CBool) CR2WTypeManager.Create("Bool", "Unlocked", cr2w, this);
				}
				return _unlocked;
			}
			set
			{
				if (_unlocked == value)
				{
					return;
				}
				_unlocked = value;
				PropertySet(this);
			}
		}

		public SCodexRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
