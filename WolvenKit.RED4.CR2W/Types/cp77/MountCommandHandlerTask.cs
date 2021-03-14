using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MountCommandHandlerTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _command;
		private CHandle<AIArgumentMapping> _mountEventData;
		private CName _callbackName;

		[Ordinal(0)] 
		[RED("command")] 
		public CHandle<AIArgumentMapping> Command
		{
			get
			{
				if (_command == null)
				{
					_command = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "command", cr2w, this);
				}
				return _command;
			}
			set
			{
				if (_command == value)
				{
					return;
				}
				_command = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mountEventData")] 
		public CHandle<AIArgumentMapping> MountEventData
		{
			get
			{
				if (_mountEventData == null)
				{
					_mountEventData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "mountEventData", cr2w, this);
				}
				return _mountEventData;
			}
			set
			{
				if (_mountEventData == value)
				{
					return;
				}
				_mountEventData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get
			{
				if (_callbackName == null)
				{
					_callbackName = (CName) CR2WTypeManager.Create("CName", "callbackName", cr2w, this);
				}
				return _callbackName;
			}
			set
			{
				if (_callbackName == value)
				{
					return;
				}
				_callbackName = value;
				PropertySet(this);
			}
		}

		public MountCommandHandlerTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
