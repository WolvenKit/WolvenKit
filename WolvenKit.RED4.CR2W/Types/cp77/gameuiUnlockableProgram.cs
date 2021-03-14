using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiUnlockableProgram : CVariable
	{
		private CName _name;
		private CName _note;
		private CBool _isFulfilled;
		private TweakDBID _programTweakID;
		private TweakDBID _iconTweakID;
		private CBool _hidden;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("note")] 
		public CName Note
		{
			get
			{
				if (_note == null)
				{
					_note = (CName) CR2WTypeManager.Create("CName", "note", cr2w, this);
				}
				return _note;
			}
			set
			{
				if (_note == value)
				{
					return;
				}
				_note = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isFulfilled")] 
		public CBool IsFulfilled
		{
			get
			{
				if (_isFulfilled == null)
				{
					_isFulfilled = (CBool) CR2WTypeManager.Create("Bool", "isFulfilled", cr2w, this);
				}
				return _isFulfilled;
			}
			set
			{
				if (_isFulfilled == value)
				{
					return;
				}
				_isFulfilled = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("programTweakID")] 
		public TweakDBID ProgramTweakID
		{
			get
			{
				if (_programTweakID == null)
				{
					_programTweakID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "programTweakID", cr2w, this);
				}
				return _programTweakID;
			}
			set
			{
				if (_programTweakID == value)
				{
					return;
				}
				_programTweakID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("iconTweakID")] 
		public TweakDBID IconTweakID
		{
			get
			{
				if (_iconTweakID == null)
				{
					_iconTweakID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "iconTweakID", cr2w, this);
				}
				return _iconTweakID;
			}
			set
			{
				if (_iconTweakID == value)
				{
					return;
				}
				_iconTweakID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hidden")] 
		public CBool Hidden
		{
			get
			{
				if (_hidden == null)
				{
					_hidden = (CBool) CR2WTypeManager.Create("Bool", "hidden", cr2w, this);
				}
				return _hidden;
			}
			set
			{
				if (_hidden == value)
				{
					return;
				}
				_hidden = value;
				PropertySet(this);
			}
		}

		public gameuiUnlockableProgram(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
