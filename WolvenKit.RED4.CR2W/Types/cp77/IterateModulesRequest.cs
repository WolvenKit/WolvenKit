using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IterateModulesRequest : gameScriptableSystemRequest
	{
		private CArray<HUDJob> _remainingJobs;

		[Ordinal(0)] 
		[RED("remainingJobs")] 
		public CArray<HUDJob> RemainingJobs
		{
			get
			{
				if (_remainingJobs == null)
				{
					_remainingJobs = (CArray<HUDJob>) CR2WTypeManager.Create("array:HUDJob", "remainingJobs", cr2w, this);
				}
				return _remainingJobs;
			}
			set
			{
				if (_remainingJobs == value)
				{
					return;
				}
				_remainingJobs = value;
				PropertySet(this);
			}
		}

		public IterateModulesRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
