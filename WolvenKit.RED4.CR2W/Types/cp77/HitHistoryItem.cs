using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitHistoryItem : CVariable
	{
		private wCHandle<gameObject> _instigator;
		private CFloat _hitTime;
		private CBool _isMelee;

		[Ordinal(0)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hitTime")] 
		public CFloat HitTime
		{
			get
			{
				if (_hitTime == null)
				{
					_hitTime = (CFloat) CR2WTypeManager.Create("Float", "hitTime", cr2w, this);
				}
				return _hitTime;
			}
			set
			{
				if (_hitTime == value)
				{
					return;
				}
				_hitTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isMelee")] 
		public CBool IsMelee
		{
			get
			{
				if (_isMelee == null)
				{
					_isMelee = (CBool) CR2WTypeManager.Create("Bool", "isMelee", cr2w, this);
				}
				return _isMelee;
			}
			set
			{
				if (_isMelee == value)
				{
					return;
				}
				_isMelee = value;
				PropertySet(this);
			}
		}

		public HitHistoryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
