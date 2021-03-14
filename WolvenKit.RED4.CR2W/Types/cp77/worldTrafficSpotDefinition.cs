using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficSpotDefinition : ISerializable
	{
		private CFloat _length;
		private CEnum<worldTrafficSpotDirection> _direction;

		[Ordinal(0)] 
		[RED("length")] 
		public CFloat Length
		{
			get
			{
				if (_length == null)
				{
					_length = (CFloat) CR2WTypeManager.Create("Float", "length", cr2w, this);
				}
				return _length;
			}
			set
			{
				if (_length == value)
				{
					return;
				}
				_length = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<worldTrafficSpotDirection> Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CEnum<worldTrafficSpotDirection>) CR2WTypeManager.Create("worldTrafficSpotDirection", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		public worldTrafficSpotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
