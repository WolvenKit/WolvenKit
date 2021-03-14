using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitStatusEffectPresentPrereq : GenericHitPrereq
	{
		private CString _checkType;
		private CString _statusEffectParam;
		private CName _tag;

		[Ordinal(5)] 
		[RED("checkType")] 
		public CString CheckType
		{
			get
			{
				if (_checkType == null)
				{
					_checkType = (CString) CR2WTypeManager.Create("String", "checkType", cr2w, this);
				}
				return _checkType;
			}
			set
			{
				if (_checkType == value)
				{
					return;
				}
				_checkType = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("statusEffectParam")] 
		public CString StatusEffectParam
		{
			get
			{
				if (_statusEffectParam == null)
				{
					_statusEffectParam = (CString) CR2WTypeManager.Create("String", "statusEffectParam", cr2w, this);
				}
				return _statusEffectParam;
			}
			set
			{
				if (_statusEffectParam == value)
				{
					return;
				}
				_statusEffectParam = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		public HitStatusEffectPresentPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
