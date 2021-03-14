using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterFleeingNPC : gameScriptableSystemRequest
	{
		private wCHandle<entEntity> _runner;
		private CFloat _timestamp;

		[Ordinal(0)] 
		[RED("runner")] 
		public wCHandle<entEntity> Runner
		{
			get
			{
				if (_runner == null)
				{
					_runner = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "runner", cr2w, this);
				}
				return _runner;
			}
			set
			{
				if (_runner == value)
				{
					return;
				}
				_runner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public CFloat Timestamp
		{
			get
			{
				if (_timestamp == null)
				{
					_timestamp = (CFloat) CR2WTypeManager.Create("Float", "timestamp", cr2w, this);
				}
				return _timestamp;
			}
			set
			{
				if (_timestamp == value)
				{
					return;
				}
				_timestamp = value;
				PropertySet(this);
			}
		}

		public RegisterFleeingNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
