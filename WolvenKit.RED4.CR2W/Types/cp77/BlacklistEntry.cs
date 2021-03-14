using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlacklistEntry : IScriptable
	{
		private entEntityID _entryID;
		private CEnum<BlacklistReason> _entryReason;
		private CInt32 _warningsCount;
		private CInt32 _reprimandID;

		[Ordinal(0)] 
		[RED("entryID")] 
		public entEntityID EntryID
		{
			get
			{
				if (_entryID == null)
				{
					_entryID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entryID", cr2w, this);
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

		[Ordinal(1)] 
		[RED("entryReason")] 
		public CEnum<BlacklistReason> EntryReason
		{
			get
			{
				if (_entryReason == null)
				{
					_entryReason = (CEnum<BlacklistReason>) CR2WTypeManager.Create("BlacklistReason", "entryReason", cr2w, this);
				}
				return _entryReason;
			}
			set
			{
				if (_entryReason == value)
				{
					return;
				}
				_entryReason = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("warningsCount")] 
		public CInt32 WarningsCount
		{
			get
			{
				if (_warningsCount == null)
				{
					_warningsCount = (CInt32) CR2WTypeManager.Create("Int32", "warningsCount", cr2w, this);
				}
				return _warningsCount;
			}
			set
			{
				if (_warningsCount == value)
				{
					return;
				}
				_warningsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("reprimandID")] 
		public CInt32 ReprimandID
		{
			get
			{
				if (_reprimandID == null)
				{
					_reprimandID = (CInt32) CR2WTypeManager.Create("Int32", "reprimandID", cr2w, this);
				}
				return _reprimandID;
			}
			set
			{
				if (_reprimandID == value)
				{
					return;
				}
				_reprimandID = value;
				PropertySet(this);
			}
		}

		public BlacklistEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
