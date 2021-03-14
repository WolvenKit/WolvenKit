using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MoveToCoverCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CHandle<AIArgumentMapping> _inCommand;
		private CBool _releaseSignalOnCoverEnter;
		private CBool _useSpecialAction;
		private CBool _useHigh;
		private CBool _useLeft;
		private CBool _useRight;

		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get
			{
				if (_inCommand == null)
				{
					_inCommand = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "inCommand", cr2w, this);
				}
				return _inCommand;
			}
			set
			{
				if (_inCommand == value)
				{
					return;
				}
				_inCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("releaseSignalOnCoverEnter")] 
		public CBool ReleaseSignalOnCoverEnter
		{
			get
			{
				if (_releaseSignalOnCoverEnter == null)
				{
					_releaseSignalOnCoverEnter = (CBool) CR2WTypeManager.Create("Bool", "releaseSignalOnCoverEnter", cr2w, this);
				}
				return _releaseSignalOnCoverEnter;
			}
			set
			{
				if (_releaseSignalOnCoverEnter == value)
				{
					return;
				}
				_releaseSignalOnCoverEnter = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("useSpecialAction")] 
		public CBool UseSpecialAction
		{
			get
			{
				if (_useSpecialAction == null)
				{
					_useSpecialAction = (CBool) CR2WTypeManager.Create("Bool", "useSpecialAction", cr2w, this);
				}
				return _useSpecialAction;
			}
			set
			{
				if (_useSpecialAction == value)
				{
					return;
				}
				_useSpecialAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useHigh")] 
		public CBool UseHigh
		{
			get
			{
				if (_useHigh == null)
				{
					_useHigh = (CBool) CR2WTypeManager.Create("Bool", "useHigh", cr2w, this);
				}
				return _useHigh;
			}
			set
			{
				if (_useHigh == value)
				{
					return;
				}
				_useHigh = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("useLeft")] 
		public CBool UseLeft
		{
			get
			{
				if (_useLeft == null)
				{
					_useLeft = (CBool) CR2WTypeManager.Create("Bool", "useLeft", cr2w, this);
				}
				return _useLeft;
			}
			set
			{
				if (_useLeft == value)
				{
					return;
				}
				_useLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("useRight")] 
		public CBool UseRight
		{
			get
			{
				if (_useRight == null)
				{
					_useRight = (CBool) CR2WTypeManager.Create("Bool", "useRight", cr2w, this);
				}
				return _useRight;
			}
			set
			{
				if (_useRight == value)
				{
					return;
				}
				_useRight = value;
				PropertySet(this);
			}
		}

		public MoveToCoverCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
