using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformOperationRequest : gameReplAnimTransformRequestBase
	{
		private CName _animName;
		private CUInt8 _operationType;

		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (CName) CR2WTypeManager.Create("CName", "animName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("operationType")] 
		public CUInt8 OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CUInt8) CR2WTypeManager.Create("Uint8", "operationType", cr2w, this);
				}
				return _operationType;
			}
			set
			{
				if (_operationType == value)
				{
					return;
				}
				_operationType = value;
				PropertySet(this);
			}
		}

		public gameReplAnimTransformOperationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
