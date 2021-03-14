using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TeleportCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _position;
		private CHandle<AIArgumentMapping> _rotation;
		private CHandle<AIArgumentMapping> _doNavTest;

		[Ordinal(1)] 
		[RED("position")] 
		public CHandle<AIArgumentMapping> Position
		{
			get
			{
				if (_position == null)
				{
					_position = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rotation")] 
		public CHandle<AIArgumentMapping> Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "rotation", cr2w, this);
				}
				return _rotation;
			}
			set
			{
				if (_rotation == value)
				{
					return;
				}
				_rotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("doNavTest")] 
		public CHandle<AIArgumentMapping> DoNavTest
		{
			get
			{
				if (_doNavTest == null)
				{
					_doNavTest = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "doNavTest", cr2w, this);
				}
				return _doNavTest;
			}
			set
			{
				if (_doNavTest == value)
				{
					return;
				}
				_doNavTest = value;
				PropertySet(this);
			}
		}

		public TeleportCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
