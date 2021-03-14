using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedebugFailureId : CVariable
	{
		private CUInt32 _threadId;
		private CUInt32 _unsignedId;

		[Ordinal(0)] 
		[RED("threadId")] 
		public CUInt32 ThreadId
		{
			get
			{
				if (_threadId == null)
				{
					_threadId = (CUInt32) CR2WTypeManager.Create("Uint32", "threadId", cr2w, this);
				}
				return _threadId;
			}
			set
			{
				if (_threadId == value)
				{
					return;
				}
				_threadId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("unsignedId")] 
		public CUInt32 UnsignedId
		{
			get
			{
				if (_unsignedId == null)
				{
					_unsignedId = (CUInt32) CR2WTypeManager.Create("Uint32", "unsignedId", cr2w, this);
				}
				return _unsignedId;
			}
			set
			{
				if (_unsignedId == value)
				{
					return;
				}
				_unsignedId = value;
				PropertySet(this);
			}
		}

		public gamedebugFailureId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
