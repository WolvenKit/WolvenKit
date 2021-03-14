using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPatrolParams : questAICommandParams
	{
		private CHandle<AIPatrolPathParameters> _pathParams;
		private CBool _repeatCommandOnInterrupt;

		[Ordinal(0)] 
		[RED("pathParams")] 
		public CHandle<AIPatrolPathParameters> PathParams
		{
			get
			{
				if (_pathParams == null)
				{
					_pathParams = (CHandle<AIPatrolPathParameters>) CR2WTypeManager.Create("handle:AIPatrolPathParameters", "pathParams", cr2w, this);
				}
				return _pathParams;
			}
			set
			{
				if (_pathParams == value)
				{
					return;
				}
				_pathParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get
			{
				if (_repeatCommandOnInterrupt == null)
				{
					_repeatCommandOnInterrupt = (CBool) CR2WTypeManager.Create("Bool", "repeatCommandOnInterrupt", cr2w, this);
				}
				return _repeatCommandOnInterrupt;
			}
			set
			{
				if (_repeatCommandOnInterrupt == value)
				{
					return;
				}
				_repeatCommandOnInterrupt = value;
				PropertySet(this);
			}
		}

		public questPatrolParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
