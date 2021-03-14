using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatRandom : animAnimNode_FloatValue
	{
		private CBool _rand;
		private CFloat _cooldown;
		private CFloat _min;
		private CFloat _max;

		[Ordinal(11)] 
		[RED("rand")] 
		public CBool Rand
		{
			get
			{
				if (_rand == null)
				{
					_rand = (CBool) CR2WTypeManager.Create("Bool", "rand", cr2w, this);
				}
				return _rand;
			}
			set
			{
				if (_rand == value)
				{
					return;
				}
				_rand = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get
			{
				if (_cooldown == null)
				{
					_cooldown = (CFloat) CR2WTypeManager.Create("Float", "cooldown", cr2w, this);
				}
				return _cooldown;
			}
			set
			{
				if (_cooldown == value)
				{
					return;
				}
				_cooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("min")] 
		public CFloat Min
		{
			get
			{
				if (_min == null)
				{
					_min = (CFloat) CR2WTypeManager.Create("Float", "min", cr2w, this);
				}
				return _min;
			}
			set
			{
				if (_min == value)
				{
					return;
				}
				_min = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("max")] 
		public CFloat Max
		{
			get
			{
				if (_max == null)
				{
					_max = (CFloat) CR2WTypeManager.Create("Float", "max", cr2w, this);
				}
				return _max;
			}
			set
			{
				if (_max == value)
				{
					return;
				}
				_max = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FloatRandom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
