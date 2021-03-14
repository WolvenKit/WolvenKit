using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CacheStatusEffectAnimEvent : redEvent
	{
		private CBool _removeCachedStatusEffect;

		[Ordinal(0)] 
		[RED("removeCachedStatusEffect")] 
		public CBool RemoveCachedStatusEffect
		{
			get
			{
				if (_removeCachedStatusEffect == null)
				{
					_removeCachedStatusEffect = (CBool) CR2WTypeManager.Create("Bool", "removeCachedStatusEffect", cr2w, this);
				}
				return _removeCachedStatusEffect;
			}
			set
			{
				if (_removeCachedStatusEffect == value)
				{
					return;
				}
				_removeCachedStatusEffect = value;
				PropertySet(this);
			}
		}

		public CacheStatusEffectAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
