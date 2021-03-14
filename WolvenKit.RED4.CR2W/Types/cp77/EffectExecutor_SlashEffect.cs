using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_SlashEffect : gameEffectExecutor_Scripted
	{
		private CArray<EffectExecutor_SlashEffect_Entry> _entries;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<EffectExecutor_SlashEffect_Entry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<EffectExecutor_SlashEffect_Entry>) CR2WTypeManager.Create("array:EffectExecutor_SlashEffect_Entry", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		public EffectExecutor_SlashEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
