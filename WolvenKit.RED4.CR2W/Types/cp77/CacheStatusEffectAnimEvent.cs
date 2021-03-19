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
			get => GetProperty(ref _removeCachedStatusEffect);
			set => SetProperty(ref _removeCachedStatusEffect, value);
		}

		public CacheStatusEffectAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
