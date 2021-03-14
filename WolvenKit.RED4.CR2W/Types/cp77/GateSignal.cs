using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GateSignal : gameTaggedSignalUserData
	{
		private CHandle<AISignalSenderTask> _data;
		private CFloat _priority;
		private CFloat _lifeTime;

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<AISignalSenderTask> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<AISignalSenderTask>) CR2WTypeManager.Create("handle:AISignalSenderTask", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CFloat Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CFloat) CR2WTypeManager.Create("Float", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lifeTime")] 
		public CFloat LifeTime
		{
			get
			{
				if (_lifeTime == null)
				{
					_lifeTime = (CFloat) CR2WTypeManager.Create("Float", "lifeTime", cr2w, this);
				}
				return _lifeTime;
			}
			set
			{
				if (_lifeTime == value)
				{
					return;
				}
				_lifeTime = value;
				PropertySet(this);
			}
		}

		public GateSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
