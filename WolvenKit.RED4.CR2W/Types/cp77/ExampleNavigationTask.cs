using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExampleNavigationTask : AIbehaviortaskScript
	{
		private CUInt32 _queryId;
		private CBool _queryStarted;

		[Ordinal(0)] 
		[RED("queryId")] 
		public CUInt32 QueryId
		{
			get
			{
				if (_queryId == null)
				{
					_queryId = (CUInt32) CR2WTypeManager.Create("Uint32", "queryId", cr2w, this);
				}
				return _queryId;
			}
			set
			{
				if (_queryId == value)
				{
					return;
				}
				_queryId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("queryStarted")] 
		public CBool QueryStarted
		{
			get
			{
				if (_queryStarted == null)
				{
					_queryStarted = (CBool) CR2WTypeManager.Create("Bool", "queryStarted", cr2w, this);
				}
				return _queryStarted;
			}
			set
			{
				if (_queryStarted == value)
				{
					return;
				}
				_queryStarted = value;
				PropertySet(this);
			}
		}

		public ExampleNavigationTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
