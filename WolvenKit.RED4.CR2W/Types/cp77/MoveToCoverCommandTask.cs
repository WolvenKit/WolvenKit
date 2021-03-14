using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MoveToCoverCommandTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inCommand;
		private wCHandle<AIMoveToCoverCommand> _currentCommand;
		private CUInt64 _coverID;

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
		[RED("currentCommand")] 
		public wCHandle<AIMoveToCoverCommand> CurrentCommand
		{
			get
			{
				if (_currentCommand == null)
				{
					_currentCommand = (wCHandle<AIMoveToCoverCommand>) CR2WTypeManager.Create("whandle:AIMoveToCoverCommand", "currentCommand", cr2w, this);
				}
				return _currentCommand;
			}
			set
			{
				if (_currentCommand == value)
				{
					return;
				}
				_currentCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("coverID")] 
		public CUInt64 CoverID
		{
			get
			{
				if (_coverID == null)
				{
					_coverID = (CUInt64) CR2WTypeManager.Create("Uint64", "coverID", cr2w, this);
				}
				return _coverID;
			}
			set
			{
				if (_coverID == value)
				{
					return;
				}
				_coverID = value;
				PropertySet(this);
			}
		}

		public MoveToCoverCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
