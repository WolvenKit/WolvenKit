using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGateSignal : CVariable
	{
		private CStatic<CName> _tags;
		private CEnum<AISignalFlags> _flags;
		private CFloat _priority;
		private CFloat _lifeTime;

		[Ordinal(0)] 
		[RED("tags", 4)] 
		public CStatic<CName> Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (CStatic<CName>) CR2WTypeManager.Create("static:4,CName", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CEnum<AISignalFlags> Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CEnum<AISignalFlags>) CR2WTypeManager.Create("AISignalFlags", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
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

		public AIGateSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
