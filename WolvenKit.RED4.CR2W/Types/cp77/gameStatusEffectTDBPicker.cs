using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffectTDBPicker : CVariable
	{
		private TweakDBID _statusEffect;

		[Ordinal(0)] 
		[RED("statusEffect")] 
		public TweakDBID StatusEffect
		{
			get
			{
				if (_statusEffect == null)
				{
					_statusEffect = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffect", cr2w, this);
				}
				return _statusEffect;
			}
			set
			{
				if (_statusEffect == value)
				{
					return;
				}
				_statusEffect = value;
				PropertySet(this);
			}
		}

		public gameStatusEffectTDBPicker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
