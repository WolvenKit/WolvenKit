using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReprimandEscalationEvent : redEvent
	{
		private CBool _startReprimand;
		private CBool _startDeescalate;

		[Ordinal(0)] 
		[RED("startReprimand")] 
		public CBool StartReprimand
		{
			get
			{
				if (_startReprimand == null)
				{
					_startReprimand = (CBool) CR2WTypeManager.Create("Bool", "startReprimand", cr2w, this);
				}
				return _startReprimand;
			}
			set
			{
				if (_startReprimand == value)
				{
					return;
				}
				_startReprimand = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("startDeescalate")] 
		public CBool StartDeescalate
		{
			get
			{
				if (_startDeescalate == null)
				{
					_startDeescalate = (CBool) CR2WTypeManager.Create("Bool", "startDeescalate", cr2w, this);
				}
				return _startDeescalate;
			}
			set
			{
				if (_startDeescalate == value)
				{
					return;
				}
				_startDeescalate = value;
				PropertySet(this);
			}
		}

		public ReprimandEscalationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
