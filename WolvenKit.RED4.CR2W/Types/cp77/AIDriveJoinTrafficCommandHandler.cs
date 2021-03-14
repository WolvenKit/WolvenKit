using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDriveJoinTrafficCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outUseKinematic;
		private CHandle<AIArgumentMapping> _outNeedDriver;

		[Ordinal(1)] 
		[RED("outUseKinematic")] 
		public CHandle<AIArgumentMapping> OutUseKinematic
		{
			get
			{
				if (_outUseKinematic == null)
				{
					_outUseKinematic = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outUseKinematic", cr2w, this);
				}
				return _outUseKinematic;
			}
			set
			{
				if (_outUseKinematic == value)
				{
					return;
				}
				_outUseKinematic = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outNeedDriver")] 
		public CHandle<AIArgumentMapping> OutNeedDriver
		{
			get
			{
				if (_outNeedDriver == null)
				{
					_outNeedDriver = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outNeedDriver", cr2w, this);
				}
				return _outNeedDriver;
			}
			set
			{
				if (_outNeedDriver == value)
				{
					return;
				}
				_outNeedDriver = value;
				PropertySet(this);
			}
		}

		public AIDriveJoinTrafficCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
