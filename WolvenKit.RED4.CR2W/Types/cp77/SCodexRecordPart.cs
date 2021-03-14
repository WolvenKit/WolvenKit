using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SCodexRecordPart : CVariable
	{
		private CName _partName;
		private CString _partContent;
		private CBool _unlocked;

		[Ordinal(0)] 
		[RED("PartName")] 
		public CName PartName
		{
			get
			{
				if (_partName == null)
				{
					_partName = (CName) CR2WTypeManager.Create("CName", "PartName", cr2w, this);
				}
				return _partName;
			}
			set
			{
				if (_partName == value)
				{
					return;
				}
				_partName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("PartContent")] 
		public CString PartContent
		{
			get
			{
				if (_partContent == null)
				{
					_partContent = (CString) CR2WTypeManager.Create("String", "PartContent", cr2w, this);
				}
				return _partContent;
			}
			set
			{
				if (_partContent == value)
				{
					return;
				}
				_partContent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public SCodexRecordPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
