using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTypeRef : CVariable
	{
		private CBool _isSet;
		private CName _customType;
		private CEnum<AIArgumentType> _enumeratedType;

		[Ordinal(0)] 
		[RED("isSet")] 
		public CBool IsSet
		{
			get
			{
				if (_isSet == null)
				{
					_isSet = (CBool) CR2WTypeManager.Create("Bool", "isSet", cr2w, this);
				}
				return _isSet;
			}
			set
			{
				if (_isSet == value)
				{
					return;
				}
				_isSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("customType")] 
		public CName CustomType
		{
			get
			{
				if (_customType == null)
				{
					_customType = (CName) CR2WTypeManager.Create("CName", "customType", cr2w, this);
				}
				return _customType;
			}
			set
			{
				if (_customType == value)
				{
					return;
				}
				_customType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enumeratedType")] 
		public CEnum<AIArgumentType> EnumeratedType
		{
			get
			{
				if (_enumeratedType == null)
				{
					_enumeratedType = (CEnum<AIArgumentType>) CR2WTypeManager.Create("AIArgumentType", "enumeratedType", cr2w, this);
				}
				return _enumeratedType;
			}
			set
			{
				if (_enumeratedType == value)
				{
					return;
				}
				_enumeratedType = value;
				PropertySet(this);
			}
		}

		public AIbehaviorTypeRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
