using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageTypeIndicator : inkWidgetLogicController
	{
		private inkImageWidgetReference _damageIconRef;
		private inkTextWidgetReference _damageTypeLabelRef;

		[Ordinal(1)] 
		[RED("DamageIconRef")] 
		public inkImageWidgetReference DamageIconRef
		{
			get
			{
				if (_damageIconRef == null)
				{
					_damageIconRef = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "DamageIconRef", cr2w, this);
				}
				return _damageIconRef;
			}
			set
			{
				if (_damageIconRef == value)
				{
					return;
				}
				_damageIconRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("DamageTypeLabelRef")] 
		public inkTextWidgetReference DamageTypeLabelRef
		{
			get
			{
				if (_damageTypeLabelRef == null)
				{
					_damageTypeLabelRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "DamageTypeLabelRef", cr2w, this);
				}
				return _damageTypeLabelRef;
			}
			set
			{
				if (_damageTypeLabelRef == value)
				{
					return;
				}
				_damageTypeLabelRef = value;
				PropertySet(this);
			}
		}

		public DamageTypeIndicator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
