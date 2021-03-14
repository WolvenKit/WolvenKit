using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgramProgressData : CVariable
	{
		private CString _id;
		private CArray<CInt32> _completionProgress;
		private CBool _isComplete;
		private CBool _revealLocalizedName;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CString) CR2WTypeManager.Create("String", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("completionProgress")] 
		public CArray<CInt32> CompletionProgress
		{
			get
			{
				if (_completionProgress == null)
				{
					_completionProgress = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "completionProgress", cr2w, this);
				}
				return _completionProgress;
			}
			set
			{
				if (_completionProgress == value)
				{
					return;
				}
				_completionProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isComplete")] 
		public CBool IsComplete
		{
			get
			{
				if (_isComplete == null)
				{
					_isComplete = (CBool) CR2WTypeManager.Create("Bool", "isComplete", cr2w, this);
				}
				return _isComplete;
			}
			set
			{
				if (_isComplete == value)
				{
					return;
				}
				_isComplete = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("revealLocalizedName")] 
		public CBool RevealLocalizedName
		{
			get
			{
				if (_revealLocalizedName == null)
				{
					_revealLocalizedName = (CBool) CR2WTypeManager.Create("Bool", "revealLocalizedName", cr2w, this);
				}
				return _revealLocalizedName;
			}
			set
			{
				if (_revealLocalizedName == value)
				{
					return;
				}
				_revealLocalizedName = value;
				PropertySet(this);
			}
		}

		public ProgramProgressData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
