using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDevelopmentPoints : CVariable
	{
		private CEnum<gamedataDevelopmentPointType> _type;
		private CInt32 _spent;
		private CInt32 _unspent;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataDevelopmentPointType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataDevelopmentPointType>) CR2WTypeManager.Create("gamedataDevelopmentPointType", "type", cr2w, this);
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
		[RED("spent")] 
		public CInt32 Spent
		{
			get
			{
				if (_spent == null)
				{
					_spent = (CInt32) CR2WTypeManager.Create("Int32", "spent", cr2w, this);
				}
				return _spent;
			}
			set
			{
				if (_spent == value)
				{
					return;
				}
				_spent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("unspent")] 
		public CInt32 Unspent
		{
			get
			{
				if (_unspent == null)
				{
					_unspent = (CInt32) CR2WTypeManager.Create("Int32", "unspent", cr2w, this);
				}
				return _unspent;
			}
			set
			{
				if (_unspent == value)
				{
					return;
				}
				_unspent = value;
				PropertySet(this);
			}
		}

		public SDevelopmentPoints(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
