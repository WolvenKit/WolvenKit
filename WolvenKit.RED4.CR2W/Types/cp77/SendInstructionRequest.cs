using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SendInstructionRequest : gameScriptableSystemRequest
	{
		private CArray<HUDJob> _jobs;

		[Ordinal(0)] 
		[RED("jobs")] 
		public CArray<HUDJob> Jobs
		{
			get
			{
				if (_jobs == null)
				{
					_jobs = (CArray<HUDJob>) CR2WTypeManager.Create("array:HUDJob", "jobs", cr2w, this);
				}
				return _jobs;
			}
			set
			{
				if (_jobs == value)
				{
					return;
				}
				_jobs = value;
				PropertySet(this);
			}
		}

		public SendInstructionRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
