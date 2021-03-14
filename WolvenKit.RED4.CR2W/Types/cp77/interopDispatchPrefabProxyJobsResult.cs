using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopDispatchPrefabProxyJobsResult : CVariable
	{
		private CUInt32 _numProxyJobsDispatched;
		private CUInt32 _numProxyJobsSkipped;
		private CUInt32 _numProxyJobsFailed;

		[Ordinal(0)] 
		[RED("numProxyJobsDispatched")] 
		public CUInt32 NumProxyJobsDispatched
		{
			get
			{
				if (_numProxyJobsDispatched == null)
				{
					_numProxyJobsDispatched = (CUInt32) CR2WTypeManager.Create("Uint32", "numProxyJobsDispatched", cr2w, this);
				}
				return _numProxyJobsDispatched;
			}
			set
			{
				if (_numProxyJobsDispatched == value)
				{
					return;
				}
				_numProxyJobsDispatched = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("numProxyJobsSkipped")] 
		public CUInt32 NumProxyJobsSkipped
		{
			get
			{
				if (_numProxyJobsSkipped == null)
				{
					_numProxyJobsSkipped = (CUInt32) CR2WTypeManager.Create("Uint32", "numProxyJobsSkipped", cr2w, this);
				}
				return _numProxyJobsSkipped;
			}
			set
			{
				if (_numProxyJobsSkipped == value)
				{
					return;
				}
				_numProxyJobsSkipped = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numProxyJobsFailed")] 
		public CUInt32 NumProxyJobsFailed
		{
			get
			{
				if (_numProxyJobsFailed == null)
				{
					_numProxyJobsFailed = (CUInt32) CR2WTypeManager.Create("Uint32", "numProxyJobsFailed", cr2w, this);
				}
				return _numProxyJobsFailed;
			}
			set
			{
				if (_numProxyJobsFailed == value)
				{
					return;
				}
				_numProxyJobsFailed = value;
				PropertySet(this);
			}
		}

		public interopDispatchPrefabProxyJobsResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
