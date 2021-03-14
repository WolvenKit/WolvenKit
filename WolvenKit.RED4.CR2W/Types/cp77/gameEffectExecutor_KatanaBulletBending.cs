using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_KatanaBulletBending : gameEffectExecutor_Scripted
	{
		private CArray<gameEffectExecutor_KatanaBulletBendingEffectEntry> _effects;

		[Ordinal(1)] 
		[RED("effects")] 
		public CArray<gameEffectExecutor_KatanaBulletBendingEffectEntry> Effects
		{
			get
			{
				if (_effects == null)
				{
					_effects = (CArray<gameEffectExecutor_KatanaBulletBendingEffectEntry>) CR2WTypeManager.Create("array:gameEffectExecutor_KatanaBulletBendingEffectEntry", "effects", cr2w, this);
				}
				return _effects;
			}
			set
			{
				if (_effects == value)
				{
					return;
				}
				_effects = value;
				PropertySet(this);
			}
		}

		public gameEffectExecutor_KatanaBulletBending(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
