using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDamageDealt : CVariable
	{
		private CEnum<gamedataDamageType> _type;
		private CFloat _value;
		private CEnum<gamedataStatPoolType> _affectedStatPool;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataDamageType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataDamageType>) CR2WTypeManager.Create("gamedataDamageType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CFloat) CR2WTypeManager.Create("Float", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("affectedStatPool")] 
		public CEnum<gamedataStatPoolType> AffectedStatPool
		{
			get
			{
				if (_affectedStatPool == null)
				{
					_affectedStatPool = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "affectedStatPool", cr2w, this);
				}
				return _affectedStatPool;
			}
			set
			{
				if (_affectedStatPool == value)
				{
					return;
				}
				_affectedStatPool = value;
				PropertySet(this);
			}
		}

		public SDamageDealt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
