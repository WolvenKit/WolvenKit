using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAudioSignpostTriggerNode : worldTriggerAreaNode
	{
		private CName _enterSignpost;
		private CName _exitSignpost;
		private CFloat _exitCooldown;

		[Ordinal(7)] 
		[RED("enterSignpost")] 
		public CName EnterSignpost
		{
			get
			{
				if (_enterSignpost == null)
				{
					_enterSignpost = (CName) CR2WTypeManager.Create("CName", "enterSignpost", cr2w, this);
				}
				return _enterSignpost;
			}
			set
			{
				if (_enterSignpost == value)
				{
					return;
				}
				_enterSignpost = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("exitSignpost")] 
		public CName ExitSignpost
		{
			get
			{
				if (_exitSignpost == null)
				{
					_exitSignpost = (CName) CR2WTypeManager.Create("CName", "exitSignpost", cr2w, this);
				}
				return _exitSignpost;
			}
			set
			{
				if (_exitSignpost == value)
				{
					return;
				}
				_exitSignpost = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("exitCooldown")] 
		public CFloat ExitCooldown
		{
			get
			{
				if (_exitCooldown == null)
				{
					_exitCooldown = (CFloat) CR2WTypeManager.Create("Float", "exitCooldown", cr2w, this);
				}
				return _exitCooldown;
			}
			set
			{
				if (_exitCooldown == value)
				{
					return;
				}
				_exitCooldown = value;
				PropertySet(this);
			}
		}

		public worldAudioSignpostTriggerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
